namespace Calculator2
{
    partial class Frm_CashPayAmount
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
            this.txtb_CashAmount = new System.Windows.Forms.TextBox();
            this.lbl_CashAmount = new System.Windows.Forms.Label();
            this.btn_CashOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_CashAmount
            // 
            this.txtb_CashAmount.Location = new System.Drawing.Point(12, 78);
            this.txtb_CashAmount.Name = "txtb_CashAmount";
            this.txtb_CashAmount.Size = new System.Drawing.Size(257, 22);
            this.txtb_CashAmount.TabIndex = 0;
            // 
            // lbl_CashAmount
            // 
            this.lbl_CashAmount.AutoSize = true;
            this.lbl_CashAmount.Location = new System.Drawing.Point(91, 32);
            this.lbl_CashAmount.Name = "lbl_CashAmount";
            this.lbl_CashAmount.Size = new System.Drawing.Size(94, 17);
            this.lbl_CashAmount.TabIndex = 1;
            this.lbl_CashAmount.Text = "Enter Amount";
            // 
            // btn_CashOk
            // 
            this.btn_CashOk.Location = new System.Drawing.Point(94, 125);
            this.btn_CashOk.Name = "btn_CashOk";
            this.btn_CashOk.Size = new System.Drawing.Size(75, 23);
            this.btn_CashOk.TabIndex = 2;
            this.btn_CashOk.Text = "Ok";
            this.btn_CashOk.UseVisualStyleBackColor = true;
            this.btn_CashOk.Click += new System.EventHandler(this.btn_CashOk_Click);
            // 
            // Frm_CashPayAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 175);
            this.Controls.Add(this.btn_CashOk);
            this.Controls.Add(this.lbl_CashAmount);
            this.Controls.Add(this.txtb_CashAmount);
            this.Name = "Frm_CashPayAmount";
            this.Text = "Frm_CashPayAmount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_CashAmount;
        private System.Windows.Forms.Label lbl_CashAmount;
        private System.Windows.Forms.Button btn_CashOk;
    }
}