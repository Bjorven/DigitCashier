namespace databastestLocal
{
    partial class frmMain
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
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.btn_adminSys = new System.Windows.Forms.Button();
            this.btn_bossSys = new System.Windows.Forms.Button();
            this.btn_cashierSys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(354, 10);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(56, 19);
            this.btn_LogOut.TabIndex = 0;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(10, 10);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(52, 13);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Location = new System.Drawing.Point(12, 36);
            this.EmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(17, 13);
            this.EmployeeName.TabIndex = 2;
            this.EmployeeName.Text = "\"\"";
            this.EmployeeName.Click += new System.EventHandler(this.EmployeeName_Click);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(12, 50);
            this.Surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(17, 13);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "\"\"";
            // 
            // btn_adminSys
            // 
            this.btn_adminSys.Enabled = false;
            this.btn_adminSys.Location = new System.Drawing.Point(158, 113);
            this.btn_adminSys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_adminSys.Name = "btn_adminSys";
            this.btn_adminSys.Size = new System.Drawing.Size(92, 60);
            this.btn_adminSys.TabIndex = 4;
            this.btn_adminSys.Text = "AdminSys";
            this.btn_adminSys.UseVisualStyleBackColor = true;
            this.btn_adminSys.Click += new System.EventHandler(this.btn_adminSys_Click);
            // 
            // btn_bossSys
            // 
            this.btn_bossSys.Enabled = false;
            this.btn_bossSys.Location = new System.Drawing.Point(319, 113);
            this.btn_bossSys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bossSys.Name = "btn_bossSys";
            this.btn_bossSys.Size = new System.Drawing.Size(92, 60);
            this.btn_bossSys.TabIndex = 5;
            this.btn_bossSys.Text = "Bosssys";
            this.btn_bossSys.UseVisualStyleBackColor = true;
            // 
            // btn_cashierSys
            // 
            this.btn_cashierSys.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::databastestLocal.Properties.Settings.Default, "chasieracess", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_cashierSys.Enabled = false;
            this.btn_cashierSys.Location = new System.Drawing.Point(9, 113);
            this.btn_cashierSys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cashierSys.Name = "btn_cashierSys";
            this.btn_cashierSys.Size = new System.Drawing.Size(92, 60);
            this.btn_cashierSys.TabIndex = 6;
            this.btn_cashierSys.Text = "Cashiersys";
            this.btn_cashierSys.UseVisualStyleBackColor = true;
            this.btn_cashierSys.Visible = global::databastestLocal.Properties.Settings.Default.chasieracess;
            this.btn_cashierSys.Click += new System.EventHandler(this.btn_cashierSys_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 304);
            this.Controls.Add(this.btn_cashierSys);
            this.Controls.Add(this.btn_bossSys);
            this.Controls.Add(this.btn_adminSys);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.btn_LogOut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Button btn_adminSys;
        private System.Windows.Forms.Button btn_bossSys;
        private System.Windows.Forms.Button btn_cashierSys;
    }
}