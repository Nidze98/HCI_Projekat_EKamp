namespace HCI_Projekat.Forms.AdminForms
{
    partial class AssignVolonterToKamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignVolonterToKamp));
            this.lbRadSaVolonterima = new System.Windows.Forms.Label();
            this.btnRasporediUKamp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbKampsList = new System.Windows.Forms.ComboBox();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.lbKamp = new System.Windows.Forms.Label();
            this.lbOd = new System.Windows.Forms.Label();
            this.lbDo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRadSaVolonterima
            // 
            this.lbRadSaVolonterima.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRadSaVolonterima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lbRadSaVolonterima.Location = new System.Drawing.Point(251, 18);
            this.lbRadSaVolonterima.Name = "lbRadSaVolonterima";
            this.lbRadSaVolonterima.Size = new System.Drawing.Size(333, 37);
            this.lbRadSaVolonterima.TabIndex = 16;
            this.lbRadSaVolonterima.Text = "Rad sa volonterima";
            // 
            // btnRasporediUKamp
            // 
            this.btnRasporediUKamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnRasporediUKamp.FlatAppearance.BorderSize = 0;
            this.btnRasporediUKamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRasporediUKamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRasporediUKamp.ForeColor = System.Drawing.Color.White;
            this.btnRasporediUKamp.Location = new System.Drawing.Point(284, 490);
            this.btnRasporediUKamp.Name = "btnRasporediUKamp";
            this.btnRasporediUKamp.Size = new System.Drawing.Size(212, 39);
            this.btnRasporediUKamp.TabIndex = 17;
            this.btnRasporediUKamp.Text = "Rasporedi u kamp";
            this.btnRasporediUKamp.UseVisualStyleBackColor = false;
            this.btnRasporediUKamp.Click += new System.EventHandler(this.btnRasporediUKamp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 129);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // cbKampsList
            // 
            this.cbKampsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKampsList.FormattingEnabled = true;
            this.cbKampsList.Location = new System.Drawing.Point(284, 280);
            this.cbKampsList.Name = "cbKampsList";
            this.cbKampsList.Size = new System.Drawing.Size(218, 21);
            this.cbKampsList.TabIndex = 23;
            this.cbKampsList.SelectedIndexChanged += new System.EventHandler(this.cbKampsList_SelectedIndexChanged);
            // 
            // dtpOD
            // 
            this.dtpOD.Location = new System.Drawing.Point(284, 330);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(218, 20);
            this.dtpOD.TabIndex = 24;
            // 
            // dtpDO
            // 
            this.dtpDO.Location = new System.Drawing.Point(284, 380);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(218, 20);
            this.dtpDO.TabIndex = 25;
            // 
            // lbKamp
            // 
            this.lbKamp.AutoSize = true;
            this.lbKamp.Location = new System.Drawing.Point(241, 283);
            this.lbKamp.Name = "lbKamp";
            this.lbKamp.Size = new System.Drawing.Size(40, 13);
            this.lbKamp.TabIndex = 26;
            this.lbKamp.Text = "Kamp: ";
            this.lbKamp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbOd
            // 
            this.lbOd.AutoSize = true;
            this.lbOd.Location = new System.Drawing.Point(243, 333);
            this.lbOd.Name = "lbOd";
            this.lbOd.Size = new System.Drawing.Size(27, 13);
            this.lbOd.TabIndex = 27;
            this.lbOd.Text = "Od: ";
            // 
            // lbDo
            // 
            this.lbDo.AutoSize = true;
            this.lbDo.Location = new System.Drawing.Point(243, 383);
            this.lbDo.Name = "lbDo";
            this.lbDo.Size = new System.Drawing.Size(27, 13);
            this.lbDo.TabIndex = 28;
            this.lbDo.Text = "Do: ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(25, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AssignVolonterToKamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbDo);
            this.Controls.Add(this.lbOd);
            this.Controls.Add(this.lbKamp);
            this.Controls.Add(this.dtpDO);
            this.Controls.Add(this.dtpOD);
            this.Controls.Add(this.cbKampsList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRasporediUKamp);
            this.Controls.Add(this.lbRadSaVolonterima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AssignVolonterToKamp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-Camp";
            this.Load += new System.EventHandler(this.AssignVolonterToKamp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRadSaVolonterima;
        private System.Windows.Forms.Button btnRasporediUKamp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbKampsList;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.Label lbKamp;
        private System.Windows.Forms.Label lbOd;
        private System.Windows.Forms.Label lbDo;
        private System.Windows.Forms.Button button2;
    }
}