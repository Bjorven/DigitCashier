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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.iteamSelectedButton = new System.Windows.Forms.Button();
            this.subTotalButton = new System.Windows.Forms.Button();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.SearchItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.btn_CancelSearch = new System.Windows.Forms.Button();
            this.btn_SubmitSearch = new System.Windows.Forms.Button();
            this.txtb_SearchBar = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.dG_List = new System.Windows.Forms.DataGridView();
            this.txtb_TotalPrice = new System.Windows.Forms.TextBox();
            this.pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_List)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(808, 546);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(162, 44);
            this.listBox2.TabIndex = 25;
            // 
            // iteamSelectedButton
            // 
            this.iteamSelectedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iteamSelectedButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iteamSelectedButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iteamSelectedButton.Location = new System.Drawing.Point(808, 479);
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
            this.subTotalButton.Location = new System.Drawing.Point(1008, 479);
            this.subTotalButton.Name = "subTotalButton";
            this.subTotalButton.Size = new System.Drawing.Size(162, 30);
            this.subTotalButton.TabIndex = 23;
            this.subTotalButton.Text = "TOTAL PRICE";
            this.subTotalButton.UseVisualStyleBackColor = false;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printReceiptButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printReceiptButton.Location = new System.Drawing.Point(594, 491);
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
            this.SearchItemButton.Location = new System.Drawing.Point(388, 491);
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
            this.addItemButton.Location = new System.Drawing.Point(12, 491);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(162, 79);
            this.addItemButton.TabIndex = 20;
            this.addItemButton.Text = "ADD ITEM";
            this.addItemButton.UseVisualStyleBackColor = false;
           // this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeItemButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeItemButton.Location = new System.Drawing.Point(200, 491);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(162, 79);
            this.removeItemButton.TabIndex = 19;
            this.removeItemButton.Text = "REMOVE ITEM";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.btn_CancelSearch);
            this.pnl_Search.Controls.Add(this.btn_SubmitSearch);
            this.pnl_Search.Controls.Add(this.txtb_SearchBar);
            this.pnl_Search.Controls.Add(this.lbl_Search);
            this.pnl_Search.Location = new System.Drawing.Point(370, 210);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(292, 171);
            this.pnl_Search.TabIndex = 27;
            // 
            // btn_CancelSearch
            // 
            this.btn_CancelSearch.Location = new System.Drawing.Point(214, 136);
            this.btn_CancelSearch.Name = "btn_CancelSearch";
            this.btn_CancelSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelSearch.TabIndex = 3;
            this.btn_CancelSearch.Text = "Cancel";
            this.btn_CancelSearch.UseVisualStyleBackColor = true;
            this.btn_CancelSearch.Click += new System.EventHandler(this.btn_CancelSearch_Click);
            // 
            // btn_SubmitSearch
            // 
            this.btn_SubmitSearch.Location = new System.Drawing.Point(18, 136);
            this.btn_SubmitSearch.Name = "btn_SubmitSearch";
            this.btn_SubmitSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitSearch.TabIndex = 2;
            this.btn_SubmitSearch.Text = "Search";
            this.btn_SubmitSearch.UseVisualStyleBackColor = true;
            this.btn_SubmitSearch.Click += new System.EventHandler(this.btn_SubmitSearch_Click);
            // 
            // txtb_SearchBar
            // 
            this.txtb_SearchBar.Location = new System.Drawing.Point(18, 47);
            this.txtb_SearchBar.Name = "txtb_SearchBar";
            this.txtb_SearchBar.Size = new System.Drawing.Size(271, 22);
            this.txtb_SearchBar.TabIndex = 1;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(15, 23);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(119, 17);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "Enter search item";
            // 
            // dG_List
            // 
            this.dG_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_List.Location = new System.Drawing.Point(13, 13);
            this.dG_List.Name = "dG_List";
            this.dG_List.RowTemplate.Height = 24;
            this.dG_List.Size = new System.Drawing.Size(1157, 402);
            this.dG_List.TabIndex = 29;
            // 
            // txtb_TotalPrice
            // 
            this.txtb_TotalPrice.Location = new System.Drawing.Point(1008, 547);
            this.txtb_TotalPrice.Name = "txtb_TotalPrice";
            this.txtb_TotalPrice.Size = new System.Drawing.Size(162, 22);
            this.txtb_TotalPrice.TabIndex = 30;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 611);
            this.Controls.Add(this.txtb_TotalPrice);
            this.Controls.Add(this.dG_List);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.iteamSelectedButton);
            this.Controls.Add(this.subTotalButton);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.SearchItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.pnl_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button iteamSelectedButton;
        private System.Windows.Forms.Button subTotalButton;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Button SearchItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Panel pnl_Search;
        private System.Windows.Forms.Button btn_CancelSearch;
        private System.Windows.Forms.Button btn_SubmitSearch;
        private System.Windows.Forms.TextBox txtb_SearchBar;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.DataGridView dG_List;
        private System.Windows.Forms.TextBox txtb_TotalPrice;
    }
}