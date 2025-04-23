namespace HCI_Projekat.Forms
{
    partial class ChangeOsobaSettingFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeOsobaSettingFrom));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTopChangeSettingsForm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTheme = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 130);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // labelTopChangeSettingsForm
            // 
            this.labelTopChangeSettingsForm.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopChangeSettingsForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelTopChangeSettingsForm.Location = new System.Drawing.Point(128, 25);
            this.labelTopChangeSettingsForm.Name = "labelTopChangeSettingsForm";
            this.labelTopChangeSettingsForm.Size = new System.Drawing.Size(535, 27);
            this.labelTopChangeSettingsForm.TabIndex = 22;
            this.labelTopChangeSettingsForm.Text = "Podesavanja, user";
            this.labelTopChangeSettingsForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTheme
            // 
            this.lbTheme.AutoSize = true;
            this.lbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheme.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTheme.Location = new System.Drawing.Point(281, 359);
            this.lbTheme.Name = "lbTheme";
            this.lbTheme.Size = new System.Drawing.Size(47, 16);
            this.lbTheme.TabIndex = 28;
            this.lbTheme.Text = "Tema";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLanguage.Location = new System.Drawing.Point(280, 281);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(43, 16);
            this.lbLanguage.TabIndex = 26;
            this.lbLanguage.Text = "Jezik";
            this.lbLanguage.Click += new System.EventHandler(this.lbLanguage_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "Srpski",
            "English"});
            this.cbLanguage.Location = new System.Drawing.Point(284, 304);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(218, 21);
            this.cbLanguage.TabIndex = 25;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // cbTheme
            // 
            this.cbTheme.BackColor = System.Drawing.SystemColors.Control;
            this.cbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Items.AddRange(new object[] {
            "Purple",
            "Blue",
            "Green"});
            this.cbTheme.Location = new System.Drawing.Point(284, 389);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(218, 21);
            this.cbTheme.TabIndex = 29;
            this.cbTheme.SelectedIndexChanged += new System.EventHandler(this.cbTheme_SelectedIndexChanged);
            // 
            // ChangeOsobaSettingFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.lbTheme);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTopChangeSettingsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeOsobaSettingFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-Camp";
            this.Load += new System.EventHandler(this.ChangeOsobaSettingFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTopChangeSettingsForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTheme;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ComboBox cbTheme;
    }
}