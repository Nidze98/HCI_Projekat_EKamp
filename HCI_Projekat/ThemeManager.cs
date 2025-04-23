using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HCI_Projekat.Forms;
using HCI_Projekat.Forms.AdminForms;
using HCI_Projekat.Forms.VolonterForms;
using HCI_Projekat.Properties; // Ensure you have the correct namespace for Resources

public static class ThemeManager
{
    // Define theme names
    public const string GreenTheme = "Green";
   
    public const string BlueTheme = "Blue";

    public const string PurpleTheme = "Purple";


    // Define your theme-related properties
    private static Color backgroundColor;
    private static Color foregroundColor;
    private static Color mainColor;
    private static Color fontColor;
    private static Image pictureBoxImage;
    private static Image arrowImage;
    private static string font;

    static ThemeManager()
    {
       
    }


    public static void ApplyTheme(Control rootControl)
    {
        Queue<Control> controlQueue = new Queue<Control>();
        controlQueue.Enqueue(rootControl);

        while (controlQueue.Count > 0)
        {
            Control currentControl = controlQueue.Dequeue();

            if (currentControl is Button&&currentControl.Height!=32&&currentControl.Width!=32)
            {
                var button = (Button)currentControl;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = mainColor;
                button.BackColor = mainColor;
                button.ForeColor = Color.White;
            }
            else if (currentControl is PictureBox pb&&(!(pb.Width == 32 && pb.Height == 32)))
            {
               
                pb.Image = pictureBoxImage;
               
            }
            else if (currentControl is Button pb1 && (pb1.Width == 32 && pb1.Height == 32))
            {
              
                pb1.BackgroundImage = arrowImage;
        
            }
            else if (currentControl is Label label && label.Font.Size > 20)
            {
                // Change the color of the label
                label.ForeColor =mainColor;
               // Font existingFont = label.Font;

                // Specify the new font family (e.g., "Arial") while keeping the existing font size
               // Font newFont = new Font(font, existingFont.Size , existingFont.Style);

                // Apply the new font to the label
                //label.Font = newFont;
            }
            else if (currentControl is Label label1 && label1.Font.Size < 20)
            {
         
                label1.ForeColor = fontColor;
                 Font existingFont = label1.Font;

                // Specify the new font family (e.g., "Arial") while keeping the existing font size
                 Font newFont = new Font(font, existingFont.Size , FontStyle.Bold);

                // Apply the new font to the label
                label1.Font = newFont;

            }
            else if (currentControl is DataGridView dataGridView)
            {
                // Disable visual styles for headers
                dataGridView.EnableHeadersVisualStyles = false;

                // Change font, color, and other styles of the header cells
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.Font = new Font(font, 9, FontStyle.Bold);
                columnHeaderStyle.ForeColor = mainColor;

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.HeaderCell.Style.ApplyStyle(columnHeaderStyle);
                }

                // Refresh the DataGridView to apply the changes
                dataGridView.Refresh();
            }


            foreach (Control childControl in currentControl.Controls)
            {
                controlQueue.Enqueue(childControl);
            }
        }
    }


    public static void SetTheme(string themeName,Form form)
    {
        switch (themeName)
        {
            case PurpleTheme:
                SetPurpleTheme(form);
                break;
            case BlueTheme:
                SetBlueTheme(form);
                break;
            default:
                SetGreenTheme(form);
                break;
        }
    }

 

    private static void SetGreenTheme(Form form)
    {
        // Set properties for the Purple theme (your existing theme)
        backgroundColor = Color.FromArgb(19, 140, 16);
        foregroundColor = Color.White;
        mainColor = Color.FromArgb(19, 140, 16);
        fontColor = mainColor;
        font = "Tahoma";
        if (form is AdminMenuForm)
        {
            pictureBoxImage = Resources.MenuForm_GREEN;
        }
        if (form is AssignVolonterToKamp)
        {
            pictureBoxImage = Resources.AssignVolonterToKamp_GREEN;
        }
        if (form is Login)
        {
            pictureBoxImage = Resources.Login_GREEN;
        }
        if (form is ChangeOsobaSettingFrom)
        {
            pictureBoxImage = Resources.ChangeOsobaSettingFrom_GREEN;
        }
        if (form is VolonterMenuForm)
        {
            pictureBoxImage = Resources.MenuForm_GREEN;
        }
        arrowImage = Resources.Arrow_GREEN;
        ApplyTheme(form);
    }

    private static void SetBlueTheme(Form form)
    {
        // Set properties for the Blue theme
        backgroundColor = Color.Blue;
        foregroundColor = Color.White;
        mainColor = Color.FromArgb(0, 119, 204);
        fontColor = mainColor;
        font = "Arial";
        if (form is AdminMenuForm)
        {
            pictureBoxImage = Resources.MenuForm_BLUE;
        }
        if (form is AssignVolonterToKamp)
        {
            pictureBoxImage = Resources.AssignVolonterToKamp_BLUE;
        }
        if (form is Login)
        {
            pictureBoxImage = Resources.Login_BLUE;
        }
        if (form is ChangeOsobaSettingFrom)
        {
            pictureBoxImage = Resources.ChangeOsobaSettingFrom_BLUE;
        }
        if (form is VolonterMenuForm)
        {
            pictureBoxImage = Resources.MenuForm_BLUE;
        }
        arrowImage=Resources.Arrow_BLUE;
        ApplyTheme(form);

    }
    private static void SetPurpleTheme(Form form)
    {
        // Set properties for the Blue theme
        backgroundColor = Color.Blue;
        foregroundColor = Color.White;
        mainColor = Color.FromArgb(116, 86, 174);
        fontColor = Color.DimGray;
        font = "Microsoft Sans Serif";
        if (form is AdminMenuForm)
        {
            pictureBoxImage = Resources.MenuForm_PURPLE;
        }
        if (form is AssignVolonterToKamp)
        {
            pictureBoxImage = Resources.AssignVolonterToKamp_PURPLE;
        }
        if (form is Login)
        {
            pictureBoxImage = Resources.Login_PURPLE;
        }
        if (form is ChangeOsobaSettingFrom)
        {
            pictureBoxImage = Resources.ChangeOsobaSettingFrom_PURPLE;
        }
        if (form is VolonterMenuForm)
        {
            pictureBoxImage = Resources.MenuForm_PURPLE;
        }
        arrowImage = Resources.Arrow_PURPLE;
        ApplyTheme(form);

    }
}
