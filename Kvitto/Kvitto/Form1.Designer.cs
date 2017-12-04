namespace Kvitto
{
    partial class Kvittosystem
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
            this.lBox_display = new System.Windows.Forms.ListBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_SubTot = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.lbox_ItemSel = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.txtb_Search = new System.Windows.Forms.TextBox();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.btn_SearchRId = new System.Windows.Forms.Button();
            this.btn_SearchRIdCancel = new System.Windows.Forms.Button();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBox_display
            // 
            this.lBox_display.FormattingEnabled = true;
            this.lBox_display.ItemHeight = 16;
            this.lBox_display.Location = new System.Drawing.Point(12, 19);
            this.lBox_display.Name = "lBox_display";
            this.lBox_display.Size = new System.Drawing.Size(387, 580);
            this.lBox_display.TabIndex = 0;
            this.lBox_display.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Remove.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(422, 121);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(162, 79);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "REMOVE ITEM";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(422, 19);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(162, 79);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "ADD ITEM";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(422, 224);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(162, 79);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "SEARCH RECEIPT";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Print.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(422, 325);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(162, 79);
            this.btn_Print.TabIndex = 11;
            this.btn_Print.Text = "PRINT RECEIPT";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.UseWaitCursor = true;
            this.btn_Print.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_SubTot
            // 
            this.btn_SubTot.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_SubTot.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubTot.Location = new System.Drawing.Point(422, 519);
            this.btn_SubTot.Name = "btn_SubTot";
            this.btn_SubTot.Size = new System.Drawing.Size(162, 30);
            this.btn_SubTot.TabIndex = 14;
            this.btn_SubTot.Text = "SUB TOTAL";
            this.btn_SubTot.UseVisualStyleBackColor = false;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_select.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Location = new System.Drawing.Point(422, 428);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(162, 30);
            this.btn_select.TabIndex = 15;
            this.btn_select.Text = "ITEM SELECTED";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // lbox_ItemSel
            // 
            this.lbox_ItemSel.FormattingEnabled = true;
            this.lbox_ItemSel.ItemHeight = 16;
            this.lbox_ItemSel.Location = new System.Drawing.Point(422, 464);
            this.lbox_ItemSel.Name = "lbox_ItemSel";
            this.lbox_ItemSel.Size = new System.Drawing.Size(162, 52);
            this.lbox_ItemSel.TabIndex = 16;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(422, 553);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(162, 52);
            this.listBox3.TabIndex = 17;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // txtb_Search
            // 
            this.txtb_Search.Location = new System.Drawing.Point(12, 63);
            this.txtb_Search.Name = "txtb_Search";
            this.txtb_Search.Size = new System.Drawing.Size(185, 22);
            this.txtb_Search.TabIndex = 18;
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.Color.Gray;
            this.pnl_Search.Controls.Add(this.btn_SearchRIdCancel);
            this.pnl_Search.Controls.Add(this.btn_SearchRId);
            this.pnl_Search.Controls.Add(this.lbl_Search);
            this.pnl_Search.Controls.Add(this.txtb_Search);
            this.pnl_Search.Location = new System.Drawing.Point(101, 224);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(298, 180);
            this.pnl_Search.TabIndex = 19;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(12, 20);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(85, 17);
            this.lbl_Search.TabIndex = 19;
            this.lbl_Search.Text = "Search Tool";
            // 
            // btn_SearchRId
            // 
            this.btn_SearchRId.Location = new System.Drawing.Point(12, 145);
            this.btn_SearchRId.Name = "btn_SearchRId";
            this.btn_SearchRId.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchRId.TabIndex = 20;
            this.btn_SearchRId.Text = "Search";
            this.btn_SearchRId.UseVisualStyleBackColor = true;
            this.btn_SearchRId.Click += new System.EventHandler(this.btn_SearchRId_Click);
            // 
            // btn_SearchRIdCancel
            // 
            this.btn_SearchRIdCancel.Location = new System.Drawing.Point(134, 145);
            this.btn_SearchRIdCancel.Name = "btn_SearchRIdCancel";
            this.btn_SearchRIdCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchRIdCancel.TabIndex = 21;
            this.btn_SearchRIdCancel.Text = "Cancel";
            this.btn_SearchRIdCancel.UseVisualStyleBackColor = true;
            // 
            // Kvittosystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(596, 618);
            this.Controls.Add(this.pnl_Search);
            this.Controls.Add(this.lBox_display);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.lbox_ItemSel);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_SubTot);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Remove);
            this.Name = "Kvittosystem";
            this.Text = "Kvitto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBox_display;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_SubTot;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ListBox lbox_ItemSel;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox txtb_Search;
        private System.Windows.Forms.Panel pnl_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Button btn_SearchRIdCancel;
        private System.Windows.Forms.Button btn_SearchRId;
    }
}

