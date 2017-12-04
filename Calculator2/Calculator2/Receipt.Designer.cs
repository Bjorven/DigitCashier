namespace Calculator2
{
    partial class Receipt
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
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.iteamSelectedButton = new System.Windows.Forms.Button();
            this.subTotalButton = new System.Windows.Forms.Button();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.SearchItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(422, 546);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(162, 44);
            this.listBox3.TabIndex = 26;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(422, 457);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(162, 44);
            this.listBox2.TabIndex = 25;
            // 
            // iteamSelectedButton
            // 
            this.iteamSelectedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iteamSelectedButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iteamSelectedButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iteamSelectedButton.Location = new System.Drawing.Point(422, 421);
            this.iteamSelectedButton.Name = "iteamSelectedButton";
            this.iteamSelectedButton.Size = new System.Drawing.Size(162, 30);
            this.iteamSelectedButton.TabIndex = 24;
            this.iteamSelectedButton.Text = "ITEM SELECTED";
            this.iteamSelectedButton.UseVisualStyleBackColor = false;
            // 
            // subTotalButton
            // 
            this.subTotalButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subTotalButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotalButton.Location = new System.Drawing.Point(422, 512);
            this.subTotalButton.Name = "subTotalButton";
            this.subTotalButton.Size = new System.Drawing.Size(162, 30);
            this.subTotalButton.TabIndex = 23;
            this.subTotalButton.Text = "SUB TOTAL";
            this.subTotalButton.UseVisualStyleBackColor = false;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printReceiptButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printReceiptButton.Location = new System.Drawing.Point(422, 318);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(162, 79);
            this.printReceiptButton.TabIndex = 22;
            this.printReceiptButton.Text = "PRINT RECEIPT";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.UseWaitCursor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // SearchItemButton
            // 
            this.SearchItemButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchItemButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchItemButton.Location = new System.Drawing.Point(422, 217);
            this.SearchItemButton.Name = "SearchItemButton";
            this.SearchItemButton.Size = new System.Drawing.Size(162, 79);
            this.SearchItemButton.TabIndex = 21;
            this.SearchItemButton.Text = "SEARCH RECEIPT";
            this.SearchItemButton.UseVisualStyleBackColor = false;
            this.SearchItemButton.Click += new System.EventHandler(this.SearchItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addItemButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItemButton.Location = new System.Drawing.Point(422, 12);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(162, 79);
            this.addItemButton.TabIndex = 20;
            this.addItemButton.Text = "ADD ITEM";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeItemButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeItemButton.Location = new System.Drawing.Point(422, 114);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(162, 79);
            this.removeItemButton.TabIndex = 19;
            this.removeItemButton.Text = "REMOVE ITEM";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(387, 564);
            this.listBox1.TabIndex = 18;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 611);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.iteamSelectedButton);
            this.Controls.Add(this.subTotalButton);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.SearchItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button iteamSelectedButton;
        private System.Windows.Forms.Button subTotalButton;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Button SearchItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}