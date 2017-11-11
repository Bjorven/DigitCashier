namespace dbFileTest
{
    partial class LogInGUI
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
            this.btn_logIn = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtb_UserName = new System.Windows.Forms.TextBox();
            this.txtb_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_logIn
            // 
            this.btn_logIn.Location = new System.Drawing.Point(60, 144);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(179, 93);
            this.btn_logIn.TabIndex = 0;
            this.btn_logIn.Text = "Log In";
            this.btn_logIn.UseVisualStyleBackColor = true;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(13, 13);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(13, 42);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // txtb_UserName
            // 
            this.txtb_UserName.Location = new System.Drawing.Point(102, 13);
            this.txtb_UserName.Name = "txtb_UserName";
            this.txtb_UserName.Size = new System.Drawing.Size(170, 20);
            this.txtb_UserName.TabIndex = 3;
            // 
            // txtb_Password
            // 
            this.txtb_Password.Location = new System.Drawing.Point(102, 39);
            this.txtb_Password.Name = "txtb_Password";
            this.txtb_Password.Size = new System.Drawing.Size(170, 20);
            this.txtb_Password.TabIndex = 4;
            // 
            // LogInGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtb_Password);
            this.Controls.Add(this.txtb_UserName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_logIn);
            this.Name = "LogInGUI";
            this.Text = "LogInGUI";
            this.Load += new System.EventHandler(this.LogInGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtb_UserName;
        private System.Windows.Forms.TextBox txtb_Password;
    }
}