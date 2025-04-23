namespace HCI_Projekat.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelTop = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbTheme = new System.Windows.Forms.Label();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelTop.Location = new System.Drawing.Point(156, 18);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(458, 37);
            this.labelTop.TabIndex = 7;
            this.labelTop.Text = "Get Started";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTop.Click += new System.EventHandler(this.labelTop_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(284, 304);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(218, 28);
            this.tbUsername.TabIndex = 8;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(284, 382);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(218, 28);
            this.tbPassword.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(284, 490);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(212, 39);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DimGray;
            this.labelUsername.Location = new System.Drawing.Point(281, 275);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 15);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPassword.Location = new System.Drawing.Point(281, 352);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 15);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 129);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.cbLanguage.Location = new System.Drawing.Point(583, 152);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbLanguage.TabIndex = 14;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLanguage.Location = new System.Drawing.Point(580, 134);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(40, 15);
            this.lbLanguage.TabIndex = 15;
            this.lbLanguage.Text = "Jezik";
            // 
            // lbTheme
            // 
            this.lbTheme.AutoSize = true;
            this.lbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheme.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTheme.Location = new System.Drawing.Point(580, 176);
            this.lbTheme.Name = "lbTheme";
            this.lbTheme.Size = new System.Drawing.Size(43, 15);
            this.lbTheme.TabIndex = 17;
            this.lbTheme.Text = "Tema";
            // 
            // cbTheme
            // 
            this.cbTheme.BackColor = System.Drawing.SystemColors.Control;
            this.cbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Items.AddRange(new object[] {
            "Purple",
            "Green",
            "Blue"});
            this.cbTheme.Location = new System.Drawing.Point(583, 194);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(121, 21);
            this.cbTheme.TabIndex = 16;
            this.cbTheme.SelectedIndexChanged += new System.EventHandler(this.cbTheme_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbTheme);
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.labelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Camp";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lbTheme;
        private System.Windows.Forms.ComboBox cbTheme;
    }
}