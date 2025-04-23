using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using HCI_Projekat.Models;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Linq;
using Org.BouncyCastle.Utilities.Zlib;
using System.Runtime.InteropServices.ComTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace HCI_Projekat.DBUtil
{
    internal class DBUtil
    {
        private static string user;

        private static string connectionString = ConfigurationManager.ConnectionStrings["MySQLDatabase"].ConnectionString;
        public static Osoba LogInUser(string username, string password)
        {
            MySqlConnection connection = null;
            MySqlCommand sqlCommand = null;
            MySqlCommand storedProcedure = null;
            string retrievedPassword = null;

            try
            {

                connection = new MySqlConnection(connectionString);
                connection.Open();

                sqlCommand = new MySqlCommand("SELECT lozinka FROM zaposleni WHERE KorisnickoIme = @username", connection);
                sqlCommand.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        // User not found
                      
                        return null; // Exit the method if the user is not found
                    }

                    while (reader.Read())
                    {
                        retrievedPassword = reader.GetString(0);
                    }

                    // Close the reader after retrieving the password
                    reader.Close();
                }

                if (retrievedPassword.Equals(password))
                {
                    // Check user role using stored procedure
                    string procedureCall = "CheckUserRole";
                    storedProcedure = new MySqlCommand(procedureCall, connection);
                    storedProcedure.CommandType = CommandType.StoredProcedure;

                    storedProcedure.Parameters.AddWithValue("@username", username);
                    MySqlParameter roleParameter = storedProcedure.Parameters.Add("@userRole", MySqlDbType.VarChar);
                    roleParameter.Direction = ParameterDirection.Output;

                    storedProcedure.ExecuteNonQuery();
                    string role = roleParameter.Value.ToString();

                    if ("admin".Equals(role))
                    {
                        // User is an admin
                        user = username;
                //        Console.WriteLine(user + " je admin");
                        return LoadOsoba(username, role);

                    }
                    else if ("volonter".Equals(role))
                    {
                        // User is a volunteer
                        user = username;
                //        Console.WriteLine(user + " je volonter");
                        return LoadOsoba(username, role);

                    }
                }
                else
                {
     
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connections and clean up resources
                if (sqlCommand != null)
                {
                    sqlCommand.Dispose();
                }
                if (storedProcedure != null)
                {
                    storedProcedure.Dispose();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return null;
        }
        private static Osoba LoadOsoba(string username, string type)
        {
            // List<Osoba> osobe = new List<Osoba>();
            if (type.Equals("admin")) type = "administrator";
            else if (type.Equals("volonter")) type = "volonter";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT JMB, Ime, Prezime, DatumRodjenja, Pol, Drzavljanstvo, MjestoPrebivalista, Jezik, Tema, z.KorisnickoIme, z.Lozinka " +
                "FROM osoba o " +
                "INNER JOIN zaposleni z ON o.JMB = z.Osoba_JMB " +
                $"INNER JOIN {type} a ON z.Osoba_JMB = a.Zaposleni_Osoba_JMB " +
                "WHERE z.KorisnickoIme = @username";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (type.Equals("administrator"))
                            {
                                Administrator osoba = new Administrator
                                {
                                    JMB = reader["JMB"].ToString(),
                                    Ime = reader["Ime"].ToString(),
                                    Prezime = reader["Prezime"].ToString(),
                                    DatumRodjenja = Convert.ToDateTime(reader["DatumRodjenja"]),
                                    Pol = Convert.ToChar(reader["Pol"]),
                                    Drzavljanstvo = reader["Drzavljanstvo"].ToString(),
                                    MjestoPrebivalista = reader["MjestoPrebivalista"].ToString(),
                                    KorisnickoIme = reader["KorisnickoIme"].ToString(),
                                    Lozinka = reader["Lozinka"].ToString(),
                                    Jezik = reader["Jezik"].ToString(),
                                    Tema = reader["Tema"].ToString()
                                  

                                };
                                osoba.SuperAdmin = LoadSuperAdminValue(osoba);
                                return osoba;

                            }
                            else if (type.Equals("volonter"))
                            {
                               

                                Volonter osoba = new Volonter
                                {
                                    JMB = reader["JMB"].ToString(),
                                    Ime = reader["Ime"].ToString(),
                                    Prezime = reader["Prezime"].ToString(),
                                    DatumRodjenja = Convert.ToDateTime(reader["DatumRodjenja"]),
                                    Pol = Convert.ToChar(reader["Pol"]),
                                    Drzavljanstvo = reader["Drzavljanstvo"].ToString(),
                                    MjestoPrebivalista = reader["MjestoPrebivalista"].ToString(),
                                    KorisnickoIme = reader["KorisnickoIme"].ToString(),
                                    Lozinka = reader["Lozinka"].ToString(),
                                    Jezik = reader["Jezik"].ToString(),
                                    Tema = reader["Tema"].ToString()

                                };
                                osoba = LoadVolonterskiAngazman(osoba);
                                
                                return osoba;
                            }

                        }
                    }
                }
            }
            return null;
        }
        public static List<Osoba> LoadOsobeList(string type)
        {
            List<Osoba> osobe = new List<Osoba>();
            if (type.Equals("admin")) type = "administrator";
            else if (type.Equals("volonter")) type = "volonter";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT JMB, Ime, Prezime, DatumRodjenja, Pol, Drzavljanstvo, MjestoPrebivalista, z.KorisnickoIme, z.Lozinka " +
                "FROM osoba o " +
                "INNER JOIN zaposleni z ON o.JMB = z.Osoba_JMB " +
                $"INNER JOIN {type} a ON z.Osoba_JMB = a.Zaposleni_Osoba_JMB ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (type.Equals("administrator"))
                            {
                                Administrator admin=new Administrator
                                {
                                    JMB = reader["JMB"].ToString(),
                                    Ime = reader["Ime"].ToString(),
                                    Prezime = reader["Prezime"].ToString(),
                                    DatumRodjenja = Convert.ToDateTime(reader["DatumRodjenja"]),
                                    Pol = Convert.ToChar(reader["Pol"]),
                                    Drzavljanstvo = reader["Drzavljanstvo"].ToString(),
                                    MjestoPrebivalista = reader["MjestoPrebivalista"].ToString(),
                                    KorisnickoIme = reader["KorisnickoIme"].ToString(),
                                    Lozinka = reader["Lozinka"].ToString()

                                };
                                admin.SuperAdmin = LoadSuperAdminValue(admin);
                                osobe.Add(admin);
                                //  return osoba;

                            }
                            else if (type.Equals("volonter"))
                            {
                                Volonter  osoba =  new Volonter
                                {
                                    JMB = reader["JMB"].ToString(),
                                    Ime = reader["Ime"].ToString(),
                                    Prezime = reader["Prezime"].ToString(),
                                    DatumRodjenja = Convert.ToDateTime(reader["DatumRodjenja"]),
                                    Pol = Convert.ToChar(reader["Pol"]),
                                    Drzavljanstvo = reader["Drzavljanstvo"].ToString(),
                                    MjestoPrebivalista = reader["MjestoPrebivalista"].ToString(),
                                    KorisnickoIme = reader["KorisnickoIme"].ToString(),
                                    Lozinka = reader["Lozinka"].ToString()

                                };
                                

                                osobe.Add(LoadVolonterskiAngazman(osoba));
                                //  return osoba;
                            }

                        }
                    }
                }
            }
            return osobe;
        }
        public static void AddOsoba(Osoba o)
        {
            MySqlConnection connection = null;
            MySqlCommand insertOsobaCommand = null;
            MySqlCommand insertZaposleniCommand = null;
            MySqlCommand insertAdministratorCommand = null;

            try
            { string insertAdministratorQuery = null;
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Insert into OSOBA table
                string insertOsobaQuery = "INSERT INTO OSOBA (JMB, Ime, Prezime, DatumRodjenja, Pol, Drzavljanstvo, MjestoPrebivalista) " +
                                          "VALUES (@JMB, @Ime, @Prezime, @DatumRodjenja, @Pol, @Drzavljanstvo, @MjestoPrebivalista)";

                insertOsobaCommand = new MySqlCommand(insertOsobaQuery, connection);
                insertOsobaCommand.Parameters.AddWithValue("@JMB", o.JMB);
                insertOsobaCommand.Parameters.AddWithValue("@Ime", o.Ime);
                insertOsobaCommand.Parameters.AddWithValue("@Prezime", o.Prezime);
                insertOsobaCommand.Parameters.AddWithValue("@DatumRodjenja", o.DatumRodjenja);
                insertOsobaCommand.Parameters.AddWithValue("@Pol", o.Pol);
                insertOsobaCommand.Parameters.AddWithValue("@Drzavljanstvo", o.Drzavljanstvo);
                insertOsobaCommand.Parameters.AddWithValue("@MjestoPrebivalista", o.MjestoPrebivalista);

                insertOsobaCommand.ExecuteNonQuery();

                // Insert into ZAPOSLENI table
                string insertZaposleniQuery = "INSERT INTO ZAPOSLENI (Osoba_JMB, KorisnickoIme, Lozinka) " +
                                              "VALUES (@Osoba_JMB, @KorisnickoIme, @Lozinka)";
                if (o is Administrator)
                {
                    Administrator pom = (Administrator)o;

                    insertZaposleniCommand = new MySqlCommand(insertZaposleniQuery, connection);
                    insertZaposleniCommand.Parameters.AddWithValue("@Osoba_JMB", pom.JMB);
                    insertZaposleniCommand.Parameters.AddWithValue("@KorisnickoIme", pom.KorisnickoIme);
                    insertZaposleniCommand.Parameters.AddWithValue("@Lozinka", pom.Lozinka);

                    insertZaposleniCommand.ExecuteNonQuery();

                    // Insert into ADMINISTRATOR table
                    insertAdministratorQuery = "INSERT INTO ADMINISTRATOR (Zaposleni_Osoba_JMB) " +
                                                      "VALUES (@Zaposleni_Osoba_JMB)";
                    insertAdministratorCommand = new MySqlCommand(insertAdministratorQuery, connection);
                    insertAdministratorCommand.Parameters.AddWithValue("@Zaposleni_Osoba_JMB", pom.JMB);

                    insertAdministratorCommand.ExecuteNonQuery();

               //     Console.WriteLine("Administrator added successfully!");

                }
                else if (o is Volonter)
                {
                    Volonter pom = (Volonter)o;

                    insertZaposleniCommand = new MySqlCommand(insertZaposleniQuery, connection);
                    insertZaposleniCommand.Parameters.AddWithValue("@Osoba_JMB", pom.JMB);
                    insertZaposleniCommand.Parameters.AddWithValue("@KorisnickoIme", pom.KorisnickoIme);
                    insertZaposleniCommand.Parameters.AddWithValue("@Lozinka", pom.Lozinka);

                    insertZaposleniCommand.ExecuteNonQuery();

                    // Insert into ADMINISTRATOR table
                    insertAdministratorQuery = "INSERT INTO VOLONTER (Zaposleni_Osoba_JMB) " +
                                                      "VALUES (@Zaposleni_Osoba_JMB)";
                    insertAdministratorCommand = new MySqlCommand(insertAdministratorQuery, connection);
                    insertAdministratorCommand.Parameters.AddWithValue("@Zaposleni_Osoba_JMB", pom.JMB);

                    insertAdministratorCommand.ExecuteNonQuery();

             //       Console.WriteLine("Volonter added successfully!");
                }
                else
                {
                    return; 
                }

            }
            catch (Exception ex)
            {
            //    Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (insertOsobaCommand != null)
                    insertOsobaCommand.Dispose();
                if (insertZaposleniCommand != null)
                    insertZaposleniCommand.Dispose();
                if (insertAdministratorCommand != null)
                    insertAdministratorCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
        public static void DeleteOsoba(Osoba o)
        {
            MySqlConnection connection = null;
            MySqlCommand deleteCommand = null;

            try
            {
                if (o is Administrator)
                {
                    Administrator pom = (Administrator)o;
                    connection = new MySqlConnection(connectionString);
                    connection.Open();

                    // Delete existing record from OSOBA, ZAPOSLENI, and ADMINISTRATOR tables
                    string deleteQuery = "DELETE FROM ADMINISTRATOR WHERE Zaposleni_Osoba_JMB = @JMB; " +
                                         "DELETE FROM ZAPOSLENI WHERE Osoba_JMB = @JMB; " +
                                         "DELETE FROM OSOBA WHERE JMB = @JMB; ";

                    deleteCommand = new MySqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@JMB", pom.JMB);

                    deleteCommand.ExecuteNonQuery();

                    // Insert the updated administrator
                    //  AddAdministrator(administrator);
             //       Console.WriteLine("Administrator updated successfully!");
                }
                else if (o is Volonter)
                {
                    Volonter pom = (Volonter)o;
                    DeleteVolonterskiAngazman(pom);
                    connection = new MySqlConnection(connectionString);
                    connection.Open();

                    // Delete existing record from OSOBA, ZAPOSLENI, and ADMINISTRATOR tables
                    string deleteQuery = "DELETE FROM VOLONTER WHERE Zaposleni_Osoba_JMB = @JMB; " +
                                         "DELETE FROM ZAPOSLENI WHERE Osoba_JMB = @JMB; " +
                                         "DELETE FROM OSOBA WHERE JMB = @JMB; ";

                    deleteCommand = new MySqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@JMB", pom.JMB);

                    deleteCommand.ExecuteNonQuery();

                    // Insert the updated administrator
                    //  AddAdministrator(administrator);
            //        Console.WriteLine("Administrator updated successfully!");
                }
            }
            catch (Exception ex)
            {
           //     Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (deleteCommand != null)
                    deleteCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
     
        public static void UpdateOsoba(Osoba o)
        {
            MySqlConnection connection = null;
            MySqlCommand updateOsobaCommand = null;
            MySqlCommand updateZaposleniCommand = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Update OSOBA table
                string updateOsobaQuery = "UPDATE OSOBA " +
                                           "SET Ime = @Ime, " +
                                           "    Prezime = @Prezime, " +
                                           "    DatumRodjenja = @DatumRodjenja, " +
                                           "    Pol = @Pol, " +
                                           "    Drzavljanstvo = @Drzavljanstvo, " +
                                           "    MjestoPrebivalista = @MjestoPrebivalista " +
                                           "WHERE JMB = @JMB";

                updateOsobaCommand = new MySqlCommand(updateOsobaQuery, connection);
                updateOsobaCommand.Parameters.AddWithValue("@JMB", o.JMB);
                updateOsobaCommand.Parameters.AddWithValue("@Ime", o.Ime);
                updateOsobaCommand.Parameters.AddWithValue("@Prezime", o.Prezime);
                updateOsobaCommand.Parameters.AddWithValue("@DatumRodjenja", o.DatumRodjenja);
                updateOsobaCommand.Parameters.AddWithValue("@Pol", o.Pol);
                updateOsobaCommand.Parameters.AddWithValue("@Drzavljanstvo", o.Drzavljanstvo);
                updateOsobaCommand.Parameters.AddWithValue("@MjestoPrebivalista", o.MjestoPrebivalista);

                int osobaRowsAffected = updateOsobaCommand.ExecuteNonQuery();

                // Update ZAPOSLENI table
                string updateZaposleniQuery = "UPDATE ZAPOSLENI " +
                                              "SET KorisnickoIme = @KorisnickoIme, " +
                                              "    Lozinka = @Lozinka, " +
                                              "Jezik=@Jezik, "+
                                              "Tema=@Tema "+
                                              "WHERE Osoba_JMB = @JMB";
                if (o is Volonter)
                {
                    updateZaposleniCommand = new MySqlCommand(updateZaposleniQuery, connection);
                    updateZaposleniCommand.Parameters.AddWithValue("@JMB", o.JMB);
                    updateZaposleniCommand.Parameters.AddWithValue("@KorisnickoIme", ((Volonter)o).KorisnickoIme);
                    updateZaposleniCommand.Parameters.AddWithValue("@Lozinka", ((Volonter)o).Lozinka);
                    updateZaposleniCommand.Parameters.AddWithValue("@Jezik", ((Volonter)o).Jezik);
                    updateZaposleniCommand.Parameters.AddWithValue("@Tema", ((Volonter)o).Tema);

                    int zaposleniRowsAffected = updateZaposleniCommand.ExecuteNonQuery();


                    if (osobaRowsAffected > 0 || zaposleniRowsAffected > 0)
                    {
              //          Console.WriteLine("Osoba and Zaposleni updated successfully!");
                    }
                    else
                    {
              //          Console.WriteLine("No records updated. Osoba with JMB = " + o.JMB + " not found.");
                    }
                }
                else if(o is Administrator)
                {
                    updateZaposleniCommand = new MySqlCommand(updateZaposleniQuery, connection);
                    updateZaposleniCommand.Parameters.AddWithValue("@JMB", o.JMB);
                    updateZaposleniCommand.Parameters.AddWithValue("@KorisnickoIme", ((Administrator)o).KorisnickoIme);
                    updateZaposleniCommand.Parameters.AddWithValue("@Lozinka", ((Administrator)o).Lozinka);
                    updateZaposleniCommand.Parameters.AddWithValue("@Jezik", ((Administrator)o).Jezik);
                    updateZaposleniCommand.Parameters.AddWithValue("@Tema", ((Administrator)o).Tema);

                    int zaposleniRowsAffected = updateZaposleniCommand.ExecuteNonQuery();


                    if (osobaRowsAffected > 0 || zaposleniRowsAffected > 0)
                    {
             //           Console.WriteLine("Osoba and Zaposleni updated successfully!");
                    }
                    else
                    {
             //           Console.WriteLine("No records updated. Osoba with JMB = " + o.JMB + " not found.");
                    }
                }
            }
            catch (Exception ex)
            {
         //       Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (updateOsobaCommand != null)
                    updateOsobaCommand.Dispose();
                if (updateZaposleniCommand != null)
                    updateZaposleniCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
       
        public static List<Kamp> LoadCampsFromDatabase()
        {
            List<Kamp> campsList = new List<Kamp>();
            MySqlConnection connection = null;
            MySqlCommand selectCommand = null;
            MySqlDataReader reader = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Construct the SELECT query
                string selectQuery = "SELECT K.Administrator_Zaposleni_Osoba_JMB, Ime, MJESTO_idMjesto,KorisnikKampaCount,K.STATUS_KAMPA_idSTATUS_KAMPA,idKamp, S.Status AS StatusName " +
                      "FROM KAMP K " +
                      "JOIN STATUS_KAMPA S ON K.STATUS_KAMPA_idSTATUS_KAMPA = S.idSTATUS_KAMPA";
                     
                selectCommand = new MySqlCommand(selectQuery, connection);

                // Execute the query
                reader = selectCommand.ExecuteReader();

                // Iterate through the results and populate the list
                while (reader.Read())
                {
                    Kamp kamp = new Kamp
                    {
                        // Replace these property assignments with the actual column names from your KAMP class
                        administratorJMB = reader.GetString("Administrator_Zaposleni_Osoba_JMB"),
                        ime = reader.GetString("Ime"),
                        status = reader.GetString("StatusName"),
                        mjestoID = reader.GetInt32("MJESTO_idMjesto"),
                        brojKorisnikaKampa = reader.GetInt32("KorisnikKampaCount"),
                        statusID = reader.GetInt32("STATUS_KAMPA_idSTATUS_KAMPA"),
                        id=reader.GetInt32("idKamp"),
                        
                    };

                    campsList.Add(kamp);
                }

                return campsList;
            }
            catch (Exception ex)
            {
      //          Console.WriteLine("An error occurred: " + ex.Message);
                return campsList; // Return an empty list in case of an error
            }
            finally
            {
                // Close the reader and connection in the finally block to ensure resources are released
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                if (selectCommand != null)
                    selectCommand.Dispose();

                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        public static List<Mjesto> LoadMjestoList()
        {
            List<Mjesto> mjestoList = new List<Mjesto>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT idMjesto, ImeMjesta, Drzava FROM MJESTO";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Mjesto mjesto = new Mjesto
                                {
                                    id = Convert.ToInt32(reader["idMjesto"]),
                                    naziv = reader["ImeMjesta"].ToString(),
                                    drzava = reader["Drzava"].ToString()
                                };

                                mjestoList.Add(mjesto);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
     //           Console.WriteLine("An error occurred: " + ex.Message);
            }

            return mjestoList;
        }
        public static void AddKamp(Mjesto mjesto, Kamp kamp)
        {
            MySqlConnection connection = null;
            MySqlCommand insertMjestoCommand = null;
            MySqlCommand insertKampCommand = null;
            int mjestoID = getMjestoID(mjesto);

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                if (mjestoID == 0)
                {
                    
                    // Insert into MJESTO table
                    string insertMjestoQuery = "INSERT INTO MJESTO (ImeMjesta, Drzava) " +
                                               "VALUES (@ImeMjesta, @Drzava)";

                    insertMjestoCommand = new MySqlCommand(insertMjestoQuery, connection);
                    insertMjestoCommand.Parameters.AddWithValue("@ImeMjesta", mjesto.naziv);
                    insertMjestoCommand.Parameters.AddWithValue("@Drzava", mjesto.drzava);

                    insertMjestoCommand.ExecuteNonQuery();
                }
          
                mjestoID = getMjestoID(mjesto);

                // Insert into KAMP table
                string insertKampQuery = "INSERT INTO KAMP (Administrator_Zaposleni_Osoba_JMB, Ime, STATUS_KAMPA_idSTATUS_KAMPA, MJESTO_idMjesto) " +
                                         "VALUES (@Administrator_Zaposleni_Osoba_JMB, @Ime, @STATUS_KAMPA_idSTATUS_KAMPA, @MJESTO_idMjesto)";

                insertKampCommand = new MySqlCommand(insertKampQuery, connection);
                insertKampCommand.Parameters.AddWithValue("@Administrator_Zaposleni_Osoba_JMB", kamp.administratorJMB);
                insertKampCommand.Parameters.AddWithValue("@Ime", kamp.ime);
                insertKampCommand.Parameters.AddWithValue("@STATUS_KAMPA_idSTATUS_KAMPA", kamp.getStatusID());
                insertKampCommand.Parameters.AddWithValue("@MJESTO_idMjesto",mjestoID);
                insertKampCommand.ExecuteNonQuery();

        //        Console.WriteLine("Mjesto and Kamp added successfully!");
            }
            catch (Exception ex)
            {
         //       Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (insertMjestoCommand != null)
                    insertMjestoCommand.Dispose();
                if (insertKampCommand != null)
                    insertKampCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
        private static int getMjestoID(Mjesto mjesto)
        {
            MySqlConnection connection = null;
            MySqlCommand sqlCommand = null;
            MySqlCommand storedProcedure = null;
            int id = 0;

            try
            {

                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Check user role using stored procedure
                string procedureCall = "GetMjestoId";
                storedProcedure = new MySqlCommand(procedureCall, connection);
                storedProcedure.CommandType = CommandType.StoredProcedure;

                storedProcedure.Parameters.AddWithValue("@inputImeMjesta", mjesto.naziv);
                storedProcedure.Parameters.AddWithValue("@inputDrzava", mjesto.drzava);
                MySqlParameter roleParameter = storedProcedure.Parameters.Add("@outputIdMjesto", MySqlDbType.Int32);
                roleParameter.Direction = ParameterDirection.Output;

                storedProcedure.ExecuteNonQuery();
                 id =Convert.ToInt32( roleParameter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connections and clean up resources
                if (sqlCommand != null)
                {
                    sqlCommand.Dispose();
                }
                if (storedProcedure != null)
                {
                    storedProcedure.Dispose();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return id;


        }
        public static void DeleteCamp(Kamp kamp)
        {
            MySqlConnection connection = null;
            MySqlCommand deleteCommand = null;
            List<Osoba> list =LoadOsobeList("volonter");
            foreach(Osoba o in list)
            {
                Volonter pom=(Volonter)o;
                pom.setKamp();
                if (pom.Kamp != null)
                {
                    if (pom.Kamp.id == kamp.id)
                    {
                        DeleteVolonterskiAngazman(pom);
                    }
                }

            }
            List<KorisnikKampa> list2 = LoadKorisnikKampaList(kamp);
            list2.ForEach(a=>DeleteKorisnikKampa(a));

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Create a command to delete the camp
                string deleteQuery = "DELETE FROM KAMP WHERE idKamp = @CampId";
                deleteCommand = new MySqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@CampId", kamp.id);

                // Execute the delete command
                deleteCommand.ExecuteNonQuery();

          //      Console.WriteLine($"Camp with ID {kamp.id} deleted successfully!");
            }
            catch (Exception ex)
            {
         //       Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (deleteCommand != null)
                    deleteCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
        public static void UpdateKamp(Mjesto mjesto,Kamp kamp)
        {
            /* DeleteCamp(kamp);
             AddKamp(mjesto,kamp);*/

            MySqlConnection connection = null;
            MySqlCommand updateKampCommand = null;
            MySqlCommand insertMjestoCommand = null;
            int mjestoID = getMjestoID(mjesto);


            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                if (mjestoID == 0)
                {

                    // Insert into MJESTO table
                    string insertMjestoQuery = "INSERT INTO MJESTO (ImeMjesta, Drzava) " +
                                               "VALUES (@ImeMjesta, @Drzava)";

                    insertMjestoCommand = new MySqlCommand(insertMjestoQuery, connection);
                    insertMjestoCommand.Parameters.AddWithValue("@ImeMjesta", mjesto.naziv);
                    insertMjestoCommand.Parameters.AddWithValue("@Drzava", mjesto.drzava);

                    insertMjestoCommand.ExecuteNonQuery();
                }

                mjestoID = getMjestoID(mjesto);

                // Update the KAMP table
                string updateKampQuery = "UPDATE KAMP SET Ime = @Naziv,MJESTO_idMjesto=@MjestoID, STATUS_KAMPA_idSTATUS_KAMPA = @StatusId " +
                                          "WHERE idKamp = @IdKamp";

                updateKampCommand = new MySqlCommand(updateKampQuery, connection);
                updateKampCommand.Parameters.AddWithValue("@IdKamp", kamp.id);
                updateKampCommand.Parameters.AddWithValue("@Naziv", kamp.ime);
                updateKampCommand.Parameters.AddWithValue("@MjestoID", mjestoID);
                updateKampCommand.Parameters.AddWithValue("@StatusId", kamp.getStatusID());

                // Execute the update query
                updateKampCommand.ExecuteNonQuery();



           //     Console.WriteLine("KAMP record updated successfully!");
            }
            catch (Exception ex)
            {
        //        Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Clean up resources
                if (updateKampCommand != null)
                    updateKampCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }



        }
        public static void AssignVolonterToKamp(Kamp kamp, Volonter volonter, DateTime startDate, DateTime? endDate = null)
        {
            MySqlConnection connection = null;
            MySqlCommand insertVolonterskiAngazmanCommand = null;
            DeleteVolonterskiAngazman(volonter);

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Insert into VOLONTERSKI_ANGAZMAN table
                string insertVolonterskiAngazmanQuery = "INSERT INTO VOLONTERSKI_ANGAZMAN (VOLONTER_Zaposleni_Osoba_JMB, StartDate, EndDate, KAMP_idKamp) " +
                                                        "VALUES (@JMB, @StartDate, @EndDate, @KampId)";

                insertVolonterskiAngazmanCommand = new MySqlCommand(insertVolonterskiAngazmanQuery, connection);
                insertVolonterskiAngazmanCommand.Parameters.AddWithValue("@JMB", volonter.JMB);
                insertVolonterskiAngazmanCommand.Parameters.AddWithValue("@StartDate", startDate);
                insertVolonterskiAngazmanCommand.Parameters.AddWithValue("@EndDate", endDate );
                insertVolonterskiAngazmanCommand.Parameters.AddWithValue("@KampId", kamp.id);

                insertVolonterskiAngazmanCommand.ExecuteNonQuery();

               // Console.WriteLine("Volonterski angazman added successfully!");
            }
            catch (Exception ex)
            {
               // Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (insertVolonterskiAngazmanCommand != null)
                    insertVolonterskiAngazmanCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
        public static void DeleteVolonterskiAngazman(Volonter volonter)
        {
            MySqlConnection connection = null;
            MySqlCommand deleteCommand = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                // Create a command to delete the camp
                string deleteQuery = "DELETE FROM VOLONTERSKI_ANGAZMAN WHERE VOLONTER_Zaposleni_Osoba_JMB = @JMB";
                deleteCommand = new MySqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@JMB", volonter.JMB);

                // Execute the delete command
                deleteCommand.ExecuteNonQuery();

               // Console.WriteLine($"Angazman deleted successfully!");
            }
            catch (Exception ex)
            {
              //  Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (deleteCommand != null)
                    deleteCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
        private static Volonter LoadVolonterskiAngazman(Volonter volonter)
        {
            MySqlConnection connection = null;
            MySqlCommand deleteCommand = null;
          

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand loadVolonterskiAngazman;
            string loadVolonterskiAngazmanQuery =
                "SELECT * FROM `databaseCamp`.`VOLONTERSKI_ANGAZMAN` WHERE VOLONTER_Zaposleni_Osoba_JMB=@JMB";

            loadVolonterskiAngazman = new MySqlCommand(loadVolonterskiAngazmanQuery, connection);
            loadVolonterskiAngazman.Parameters.AddWithValue("@JMB", volonter.JMB);

            using (MySqlDataReader angazmanReader = loadVolonterskiAngazman.ExecuteReader())
            {
                if (angazmanReader.Read())
                {
                    volonter.KampID = !angazmanReader.IsDBNull(angazmanReader.GetOrdinal("KAMP_idKamp")) ? angazmanReader.GetInt32("KAMP_idKamp") : -1;
                    volonter.StartDate = !angazmanReader.IsDBNull(angazmanReader.GetOrdinal("StartDate")) ? Convert.ToDateTime(angazmanReader["StartDate"]) : DateTime.MinValue;
                    volonter.EndDate = !angazmanReader.IsDBNull(angazmanReader.GetOrdinal("EndDate")) ? Convert.ToDateTime(angazmanReader["EndDate"]) : DateTime.MinValue;
                }
            }

            return volonter;
        }
  
        public static List<KorisnikKampa> LoadKorisnikKampaList(Kamp kamp)
        {
            List<KorisnikKampa> korisnikKampaList = new List<KorisnikKampa>();
 
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select data from your KORISNIK KAMPA table
                    string selectQuery = "SELECT * FROM `OSOBA` o " +
                               "RIGHT JOIN `KORISNIK KAMPA` kk ON o.JMB = kk.Osoba_JMB " +
                               "LEFT JOIN `PERIOD BORAVKA` pb ON kk.Osoba_JMB = pb.`Korisnik kampa_Osoba_JMB` " +
                               "WHERE Kamp_idKamp = @kampID;";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@kampID", kamp.id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            
                               
                                KorisnikKampa korisnikKampa = new KorisnikKampa
                                {
                                    JMB = reader["JMB"].ToString(),
                                    Ime = reader["Ime"].ToString(),
                                    Prezime = reader["Prezime"].ToString(),
                                    DatumRodjenja = Convert.ToDateTime(reader["DatumRodjenja"]),
                                    Pol = Convert.ToChar(reader["Pol"]),
                                    Drzavljanstvo = reader["Drzavljanstvo"].ToString(),
                                    MjestoPrebivalista = reader["MjestoPrebivalista"].ToString(),
                                    TipNesrece = reader["TipNesreće"].ToString(),
                                    Status= reader["Status"].ToString(),
                                    VolonterJMB = reader["VOLONTER_Zaposleni_Osoba_JMB"].ToString(),
                                    KampID = Convert.ToInt32(reader["Kamp_idKamp"]),
                                    DatumDO = Convert.ToDateTime(reader["DatumDolaska"]),
                                    DatumOD = Convert.ToDateTime(reader["DatumOdlaska"])
                                };
                                korisnikKampaList.Add(korisnikKampa);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error loading KorisnikKampa: {ex.Message}");
            }

            return korisnikKampaList;
        }
        public static void AddKorisnikKampa( KorisnikKampa korisnikKampa)
        {
            MySqlConnection connection = null;
            MySqlCommand insertOsobaCommand = null;
            MySqlCommand insertKorisnikKampaCommand = null;
            MySqlCommand insertPeriodBoravkaCommand = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert into OSOBA table
                        string insertOsobaQuery = "INSERT INTO `databaseCamp`.`OSOBA` (`JMB`, `Ime`, `Prezime`, `DatumRodjenja`, `Pol`, `Drzavljanstvo`, `MjestoPrebivalista`) " +
                                                   "VALUES (@JMB, @Ime, @Prezime, @DatumRodjenja, @Pol, @Drzavljanstvo, @MjestoPrebivalista)";

                        insertOsobaCommand = new MySqlCommand(insertOsobaQuery, connection, transaction);
                        insertOsobaCommand.Parameters.AddWithValue("@JMB", korisnikKampa.JMB);
                        insertOsobaCommand.Parameters.AddWithValue("@Ime", korisnikKampa.Ime);
                        insertOsobaCommand.Parameters.AddWithValue("@Prezime", korisnikKampa.Prezime);
                        insertOsobaCommand.Parameters.AddWithValue("@DatumRodjenja", korisnikKampa.DatumRodjenja);
                        insertOsobaCommand.Parameters.AddWithValue("@Pol", korisnikKampa.Pol);
                        insertOsobaCommand.Parameters.AddWithValue("@Drzavljanstvo", korisnikKampa.Drzavljanstvo);
                        insertOsobaCommand.Parameters.AddWithValue("@MjestoPrebivalista", korisnikKampa.MjestoPrebivalista);

                        insertOsobaCommand.ExecuteNonQuery();

                        // Insert into KORISNIK KAMPA table
                        string insertKorisnikKampaQuery = "INSERT INTO `databaseCamp`.`KORISNIK KAMPA` (`Osoba_JMB`, `TipNesreće`, `Status`, `VOLONTER_Zaposleni_Osoba_JMB`) " +
                                                          "VALUES (@Osoba_JMB, @TipNesrece, @Status, @VolonterJMB)";

                        insertKorisnikKampaCommand = new MySqlCommand(insertKorisnikKampaQuery, connection, transaction);
                        insertKorisnikKampaCommand.Parameters.AddWithValue("@Osoba_JMB", korisnikKampa.JMB);
                        insertKorisnikKampaCommand.Parameters.AddWithValue("@TipNesrece", korisnikKampa.TipNesrece);
                        insertKorisnikKampaCommand.Parameters.AddWithValue("@Status", korisnikKampa.Status);
                        insertKorisnikKampaCommand.Parameters.AddWithValue("@VolonterJMB", korisnikKampa.VolonterJMB);

                        insertKorisnikKampaCommand.ExecuteNonQuery();

                        // Insert into PERIOD BORAVKA table
                        string insertPeriodBoravkaQuery = "INSERT INTO `databaseCamp`.`PERIOD BORAVKA` (`Korisnik kampa_Osoba_JMB`, `Kamp_idKamp`, `DatumDolaska`, `DatumOdlaska`) " +
                                                          "VALUES (@Osoba_JMB, @Kamp_idKamp, @DatumDolaska, @DatumOdlaska)";

                        insertPeriodBoravkaCommand = new MySqlCommand(insertPeriodBoravkaQuery, connection, transaction);
                        insertPeriodBoravkaCommand.Parameters.AddWithValue("@Osoba_JMB", korisnikKampa.JMB);
                        insertPeriodBoravkaCommand.Parameters.AddWithValue("@Kamp_idKamp", korisnikKampa.KampID);
                        insertPeriodBoravkaCommand.Parameters.AddWithValue("@DatumDolaska", korisnikKampa.DatumDO);
                        insertPeriodBoravkaCommand.Parameters.AddWithValue("@DatumOdlaska", korisnikKampa.DatumOD);

                        insertPeriodBoravkaCommand.ExecuteNonQuery();

                        transaction.Commit();
                      //  Console.WriteLine("Korisnik Kampa and Period Boravka added successfully!");
                    }
                    catch (Exception ex)
                    {
                      //  Console.WriteLine($"Error: {ex.Message}");
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
               // Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (insertOsobaCommand != null)
                    insertOsobaCommand.Dispose();
                if (insertKorisnikKampaCommand != null)
                    insertKorisnikKampaCommand.Dispose();
                if (insertPeriodBoravkaCommand != null)
                    insertPeriodBoravkaCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
        public static void UpdateKorisnikKampa(KorisnikKampa korisnikKampa)
        {
            MySqlConnection connection = null;
            MySqlCommand updateOsobaCommand = null;
            MySqlCommand updateKorisnikKampaCommand = null;
            MySqlCommand updatePeriodBoravkaCommand = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update OSOBA table
                        string updateOsobaQuery = "UPDATE `databaseCamp`.`OSOBA` " +
                                                   "SET `Ime` = @Ime, `Prezime` = @Prezime, `DatumRodjenja` = @DatumRodjenja, `Pol` = @Pol, " +
                                                   "`Drzavljanstvo` = @Drzavljanstvo, `MjestoPrebivalista` = @MjestoPrebivalista " +
                                                   "WHERE `JMB` = @JMB";

                        updateOsobaCommand = new MySqlCommand(updateOsobaQuery, connection, transaction);
                        updateOsobaCommand.Parameters.AddWithValue("@JMB", korisnikKampa.JMB);
                        updateOsobaCommand.Parameters.AddWithValue("@Ime", korisnikKampa.Ime);
                        updateOsobaCommand.Parameters.AddWithValue("@Prezime", korisnikKampa.Prezime);
                        updateOsobaCommand.Parameters.AddWithValue("@DatumRodjenja", korisnikKampa.DatumRodjenja);
                        updateOsobaCommand.Parameters.AddWithValue("@Pol", korisnikKampa.Pol);
                        updateOsobaCommand.Parameters.AddWithValue("@Drzavljanstvo", korisnikKampa.Drzavljanstvo);
                        updateOsobaCommand.Parameters.AddWithValue("@MjestoPrebivalista", korisnikKampa.MjestoPrebivalista);

                        updateOsobaCommand.ExecuteNonQuery();

                        // Update KORISNIK KAMPA table
                        string updateKorisnikKampaQuery = "UPDATE `databaseCamp`.`KORISNIK KAMPA` " +
                                                          "SET `TipNesreće` = @TipNesrece, `Status` = @Status, `VOLONTER_Zaposleni_Osoba_JMB` = @VolonterJMB " +
                                                          "WHERE `Osoba_JMB` = @Osoba_JMB";

                        updateKorisnikKampaCommand = new MySqlCommand(updateKorisnikKampaQuery, connection, transaction);
                        updateKorisnikKampaCommand.Parameters.AddWithValue("@Osoba_JMB", korisnikKampa.JMB);
                        updateKorisnikKampaCommand.Parameters.AddWithValue("@TipNesrece", korisnikKampa.TipNesrece);
                        updateKorisnikKampaCommand.Parameters.AddWithValue("@Status", korisnikKampa.Status);
                        updateKorisnikKampaCommand.Parameters.AddWithValue("@VolonterJMB", korisnikKampa.VolonterJMB);

                        updateKorisnikKampaCommand.ExecuteNonQuery();

                        // Update PERIOD BORAVKA table
                        string updatePeriodBoravkaQuery = "UPDATE `databaseCamp`.`PERIOD BORAVKA` " +
                                                          "SET `DatumDolaska` = @DatumDolaska, `DatumOdlaska` = @DatumOdlaska " +
                                                          "WHERE `Korisnik kampa_Osoba_JMB` = @Osoba_JMB";

                        updatePeriodBoravkaCommand = new MySqlCommand(updatePeriodBoravkaQuery, connection, transaction);
                        updatePeriodBoravkaCommand.Parameters.AddWithValue("@Osoba_JMB", korisnikKampa.JMB);
                        updatePeriodBoravkaCommand.Parameters.AddWithValue("@DatumDolaska", korisnikKampa.DatumDO);
                        updatePeriodBoravkaCommand.Parameters.AddWithValue("@DatumOdlaska", korisnikKampa.DatumOD);

                        updatePeriodBoravkaCommand.ExecuteNonQuery();

                        transaction.Commit();
                  //      Console.WriteLine("Korisnik Kampa updated successfully!");
                    }
                    catch (Exception ex)
                    {
                   //     Console.WriteLine($"Error: {ex.Message}");
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
              //  Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (updateOsobaCommand != null)
                    updateOsobaCommand.Dispose();
                if (updateKorisnikKampaCommand != null)
                    updateKorisnikKampaCommand.Dispose();
                if (updatePeriodBoravkaCommand != null)
                    updatePeriodBoravkaCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
        public static void DeleteKorisnikKampa(KorisnikKampa korisnikKampa)
        {
            MySqlConnection connection = null;
            MySqlCommand deletePeriodBoravkaCommand = null;
            MySqlCommand deleteKorisnikKampaCommand = null;
            MySqlCommand deleteOsobaCommand = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete from PERIOD BORAVKA table
                        string deletePeriodBoravkaQuery = "DELETE FROM `databaseCamp`.`PERIOD BORAVKA` WHERE `Korisnik kampa_Osoba_JMB` = @Osoba_JMB";

                        deletePeriodBoravkaCommand = new MySqlCommand(deletePeriodBoravkaQuery, connection, transaction);
                        deletePeriodBoravkaCommand.Parameters.AddWithValue("@Osoba_JMB", korisnikKampa.JMB);

                        deletePeriodBoravkaCommand.ExecuteNonQuery();

                        // Delete from KORISNIK KAMPA table
                        string deleteKorisnikKampaQuery = "DELETE FROM `databaseCamp`.`KORISNIK KAMPA` WHERE `Osoba_JMB` = @Osoba_JMB";

                        deleteKorisnikKampaCommand = new MySqlCommand(deleteKorisnikKampaQuery, connection, transaction);
                        deleteKorisnikKampaCommand.Parameters.AddWithValue("@Osoba_JMB", korisnikKampa.JMB);

                        deleteKorisnikKampaCommand.ExecuteNonQuery();

                        // Delete from OSOBA table
                        string deleteOsobaQuery = "DELETE FROM `databaseCamp`.`OSOBA` WHERE `JMB` = @JMB";

                        deleteOsobaCommand = new MySqlCommand(deleteOsobaQuery, connection, transaction);
                        deleteOsobaCommand.Parameters.AddWithValue("@JMB", korisnikKampa.JMB);

                        deleteOsobaCommand.ExecuteNonQuery();

                        transaction.Commit();
                     //   Console.WriteLine("Korisnik Kampa deleted successfully!");
                    }
                    catch (Exception ex)
                    {
                     //   Console.WriteLine($"Error: {ex.Message}");
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
              //  Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (deletePeriodBoravkaCommand != null)
                    deletePeriodBoravkaCommand.Dispose();
                if (deleteKorisnikKampaCommand != null)
                    deleteKorisnikKampaCommand.Dispose();
                if (deleteOsobaCommand != null)
                    deleteOsobaCommand.Dispose();
                if (connection != null)
                    connection.Close();
            }
        }
        public static bool LoadSuperAdminValue(Administrator administrator)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT SuperAdmin FROM ADMINISTRATOR WHERE Zaposleni_Osoba_JMB = @JMB";
                    cmd.Parameters.AddWithValue("@JMB", administrator.JMB);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Check for DBNull to handle possible NULL values in the database
                            return reader["SuperAdmin"] is DBNull ? false : Convert.ToBoolean(reader["SuperAdmin"]);
                        }
                    }
                }
            }

            // Return null if the record is not found
            return false;
        }











































    }
}


