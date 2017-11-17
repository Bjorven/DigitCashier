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
            this.btn_cashier = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_boss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cashier
            // 
            this.btn_cashier.Location = new System.Drawing.Point(12, 64);
            this.btn_cashier.Name = "btn_cashier";
            this.btn_cashier.Size = new System.Drawing.Size(75, 23);
            this.btn_cashier.TabIndex = 0;
            this.btn_cashier.Text = "cashier";
            this.btn_cashier.UseVisualStyleBackColor = true;
            this.btn_cashier.Click += new System.EventHandler(this.btn_cashier_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(103, 91);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(75, 23);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_boss
            // 
            this.btn_boss.Location = new System.Drawing.Point(188, 63);
            this.btn_boss.Name = "btn_boss";
            this.btn_boss.Size = new System.Drawing.Size(75, 23);
            this.btn_boss.TabIndex = 2;
            this.btn_boss.Text = "Boss";
            this.btn_boss.UseVisualStyleBackColor = true;
            this.btn_boss.Click += new System.EventHandler(this.btn_boss_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btn_boss);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_cashier);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cashier;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_boss;
    }
}