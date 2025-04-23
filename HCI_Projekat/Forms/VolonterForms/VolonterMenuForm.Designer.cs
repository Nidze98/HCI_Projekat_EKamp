namespace HCI_Projekat.Forms.VolonterForms
{
    partial class VolonterMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolonterMenuForm));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTopVolonterMenuForm = new System.Windows.Forms.Label();
            this.btnWorkWithKorisnici = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(25, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 128);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // labelTopVolonterMenuForm
            // 
            this.labelTopVolonterMenuForm.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopVolonterMenuForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelTopVolonterMenuForm.Location = new System.Drawing.Point(229, 18);
            this.labelTopVolonterMenuForm.Name = "labelTopVolonterMenuForm";
            this.labelTopVolonterMenuForm.Size = new System.Drawing.Size(298, 37);
            this.labelTopVolonterMenuForm.TabIndex = 20;
            this.labelTopVolonterMenuForm.Text = "Welcome, Admin";
            this.labelTopVolonterMenuForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWorkWithKorisnici
            // 
            this.btnWorkWithKorisnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnWorkWithKorisnici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorkWithKorisnici.FlatAppearance.BorderSize = 0;
            this.btnWorkWithKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkWithKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkWithKorisnici.ForeColor = System.Drawing.Color.White;
            this.btnWorkWithKorisnici.Location = new System.Drawing.Point(282, 312);
            this.btnWorkWithKorisnici.Name = "btnWorkWithKorisnici";
            this.btnWorkWithKorisnici.Size = new System.Drawing.Size(212, 39);
            this.btnWorkWithKorisnici.TabIndex = 19;
            this.btnWorkWithKorisnici.Text = "Rad sa korisnicima";
            this.btnWorkWithKorisnici.UseVisualStyleBackColor = false;
            this.btnWorkWithKorisnici.Click += new System.EventHandler(this.btnWorkWithKorisnici_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(282, 403);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(212, 39);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Text = "Podešavanja";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // VolonterMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTopVolonterMenuForm);
            this.Controls.Add(this.btnWorkWithKorisnici);
            this.Controls.Add(this.btnSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VolonterMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-Camp";
            this.Load += new System.EventHandler(this.VolonterMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTopVolonterMenuForm;
        private System.Windows.Forms.Button btnWorkWithKorisnici;
        private System.Windows.Forms.Button btnSettings;
    }
}