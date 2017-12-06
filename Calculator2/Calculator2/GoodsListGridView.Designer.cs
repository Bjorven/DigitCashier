namespace Calculator2
{
    partial class GoodsListGridView
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
            this.GoodsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GoodsDataGridView
            // 
            this.GoodsDataGridView.AllowUserToAddRows = false;
            this.GoodsDataGridView.AllowUserToDeleteRows = false;
            this.GoodsDataGridView.AllowUserToResizeColumns = false;
            this.GoodsDataGridView.AllowUserToResizeRows = false;
            this.GoodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsDataGridView.Location = new System.Drawing.Point(13, 13);
            this.GoodsDataGridView.Name = "GoodsDataGridView";
            this.GoodsDataGridView.RowTemplate.Height = 24;
            this.GoodsDataGridView.Size = new System.Drawing.Size(1022, 484);
            this.GoodsDataGridView.TabIndex = 0;
            this.GoodsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsDataGridView_CellClick);
            this.GoodsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GoodsListGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 509);
            this.Controls.Add(this.GoodsDataGridView);
            this.Name = "GoodsListGridView";
            this.Text = "GoodsListGridView";
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GoodsDataGridView;
    }
}