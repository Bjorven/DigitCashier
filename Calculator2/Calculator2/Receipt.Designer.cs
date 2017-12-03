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
            this.itemSelectbutton = new System.Windows.Forms.Button();
            this.subTotalButton = new System.Windows.Forms.Button();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.searchReceptButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
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
            // itemSelectbutton
            // 
            this.itemSelectbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemSelectbutton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSelectbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemSelectbutton.Location = new System.Drawing.Point(422, 421);
            this.itemSelectbutton.Name = "itemSelectbutton";
            this.itemSelectbutton.Size = new System.Drawing.Size(162, 30);
            this.itemSelectbutton.TabIndex = 24;
            this.itemSelectbutton.Text = "ITEM SELECTED";
            this.itemSelectbutton.UseVisualStyleBackColor = false;
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
            // searchReceptButton
            // 
            this.searchReceptButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchReceptButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchReceptButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchReceptButton.Location = new System.Drawing.Point(422, 217);
            this.searchReceptButton.Name = "searchReceptButton";
            this.searchReceptButton.Size = new System.Drawing.Size(162, 79);
            this.searchReceptButton.TabIndex = 21;
            this.searchReceptButton.Text = "SEARCH RECEIPT";
            this.searchReceptButton.UseVisualStyleBackColor = false;
            this.searchReceptButton.Click += new System.EventHandler(this.searchReceptButton_Click);
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
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeButton.Location = new System.Drawing.Point(422, 114);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(162, 79);
            this.removeButton.TabIndex = 19;
            this.removeButton.Text = "REMOVE ITEM";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(387, 564);
            this.listBox.TabIndex = 18;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 611);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.itemSelectbutton);
            this.Controls.Add(this.subTotalButton);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.searchReceptButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listBox);
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
        private System.Windows.Forms.Button itemSelectbutton;
        private System.Windows.Forms.Button subTotalButton;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Button searchReceptButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox listBox;
    }
}