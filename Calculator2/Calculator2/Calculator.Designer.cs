using System;
using System.Windows.Forms;

namespace Calculator2
{
    partial class Calculator
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tenPercentButton = new System.Windows.Forms.Button();
            this.twentyPercentButton = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.thertyPercentButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BarcodeBotton = new System.Windows.Forms.Button();
            this.OkBotton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.GoodsButton = new System.Windows.Forms.Button();
            this.CardButton = new System.Windows.Forms.Button();
            this.CouponButton = new System.Windows.Forms.Button();
            this.NrEightButton = new System.Windows.Forms.Button();
            this.NrNineButton = new System.Windows.Forms.Button();
            this.NrTwoButton = new System.Windows.Forms.Button();
            this.NrThreeButton = new System.Windows.Forms.Button();
            this.nrFourButton = new System.Windows.Forms.Button();
            this.nrFiveButton = new System.Windows.Forms.Button();
            this.NrSixButton = new System.Windows.Forms.Button();
            this.NrSevenButton = new System.Windows.Forms.Button();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.CashButton = new System.Windows.Forms.Button();
            this.CommaButton = new System.Windows.Forms.Button();
            this.NrOneButton = new System.Windows.Forms.Button();
            this.DoubleZeroButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.momsButton = new System.Windows.Forms.Button();
            this.DiscountButton = new System.Windows.Forms.Button();
            this.ClearBotton = new System.Windows.Forms.Button();
            this.toPayLabel = new System.Windows.Forms.Label();
            this.couponLabel = new System.Windows.Forms.Label();
            this.couponTextBox = new System.Windows.Forms.TextBox();
            this.toPayTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.idNrTextBox = new System.Windows.Forms.TextBox();
            this.idNrLabel = new System.Windows.Forms.Label();
            this.reciptNrLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.momsTextBox = new System.Windows.Forms.TextBox();
            this.momsLabel = new System.Windows.Forms.Label();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.idnameComboBox = new System.Windows.Forms.ComboBox();
            this.goodsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_subtract = new System.Windows.Forms.Button();
            this.pnl_Amount = new System.Windows.Forms.Panel();
            this.lbl_CashAmount = new System.Windows.Forms.Label();
            this.btn_CashOk = new System.Windows.Forms.Button();
            this.txtb_CashAmount = new System.Windows.Forms.TextBox();
            this.deletRowBotton = new System.Windows.Forms.Button();
            this.reciptNrTextBox = new System.Windows.Forms.TextBox();
            this.pnl_Amount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(888, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker1.TabIndex = 237;
            // 
            // tenPercentButton
            // 
            this.tenPercentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tenPercentButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tenPercentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tenPercentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tenPercentButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenPercentButton.ForeColor = System.Drawing.Color.White;
            this.tenPercentButton.Location = new System.Drawing.Point(198, 370);
            this.tenPercentButton.Name = "tenPercentButton";
            this.tenPercentButton.Size = new System.Drawing.Size(97, 58);
            this.tenPercentButton.TabIndex = 236;
            this.tenPercentButton.Text = "10%";
            this.tenPercentButton.UseVisualStyleBackColor = false;
            this.tenPercentButton.Click += new System.EventHandler(this.TenPercentButton_Click);
            // 
            // twentyPercentButton
            // 
            this.twentyPercentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.twentyPercentButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.twentyPercentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.twentyPercentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twentyPercentButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twentyPercentButton.ForeColor = System.Drawing.Color.White;
            this.twentyPercentButton.Location = new System.Drawing.Point(198, 432);
            this.twentyPercentButton.Name = "twentyPercentButton";
            this.twentyPercentButton.Size = new System.Drawing.Size(97, 58);
            this.twentyPercentButton.TabIndex = 233;
            this.twentyPercentButton.Text = "20%";
            this.twentyPercentButton.UseVisualStyleBackColor = false;
            this.twentyPercentButton.Click += new System.EventHandler(this.TwentyPercentButton_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimesButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TimesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimesButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesButton.ForeColor = System.Drawing.Color.White;
            this.TimesButton.Location = new System.Drawing.Point(299, 432);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(97, 58);
            this.TimesButton.TabIndex = 232;
            this.TimesButton.Text = "X";
            this.TimesButton.UseVisualStyleBackColor = false;
            this.TimesButton.Click += new System.EventHandler(this.TimesButton_Click);
            // 
            // thertyPercentButton
            // 
            this.thertyPercentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thertyPercentButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thertyPercentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.thertyPercentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thertyPercentButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thertyPercentButton.ForeColor = System.Drawing.Color.White;
            this.thertyPercentButton.Location = new System.Drawing.Point(198, 497);
            this.thertyPercentButton.Name = "thertyPercentButton";
            this.thertyPercentButton.Size = new System.Drawing.Size(97, 58);
            this.thertyPercentButton.TabIndex = 231;
            this.thertyPercentButton.Text = "30%";
            this.thertyPercentButton.UseVisualStyleBackColor = false;
            this.thertyPercentButton.Click += new System.EventHandler(this.ThertyPercentButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(701, 370);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(184, 123);
            this.SearchButton.TabIndex = 230;
            this.SearchButton.Text = "#";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(892, 370);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(184, 100);
            this.CloseButton.TabIndex = 229;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BarcodeBotton
            // 
            this.BarcodeBotton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BarcodeBotton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BarcodeBotton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BarcodeBotton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BarcodeBotton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeBotton.ForeColor = System.Drawing.Color.White;
            this.BarcodeBotton.Location = new System.Drawing.Point(892, 476);
            this.BarcodeBotton.Name = "BarcodeBotton";
            this.BarcodeBotton.Size = new System.Drawing.Size(184, 100);
            this.BarcodeBotton.TabIndex = 226;
            this.BarcodeBotton.Text = "Barcode";
            this.BarcodeBotton.UseVisualStyleBackColor = false;
            this.BarcodeBotton.Click += new System.EventHandler(this.BarcodeBotton_Click);
            // 
            // OkBotton
            // 
            this.OkBotton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OkBotton.BackColor = System.Drawing.Color.Green;
            this.OkBotton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OkBotton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkBotton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBotton.ForeColor = System.Drawing.Color.White;
            this.OkBotton.Location = new System.Drawing.Point(299, 497);
            this.OkBotton.Name = "OkBotton";
            this.OkBotton.Size = new System.Drawing.Size(97, 187);
            this.OkBotton.TabIndex = 223;
            this.OkBotton.Text = "OK";
            this.OkBotton.UseVisualStyleBackColor = false;
            this.OkBotton.Click += new System.EventHandler(this.OkBotton__Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlusButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlusButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.ForeColor = System.Drawing.Color.White;
            this.PlusButton.Location = new System.Drawing.Point(299, 371);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(97, 58);
            this.PlusButton.TabIndex = 222;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(201, 561);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 123);
            this.DeleteButton.TabIndex = 221;
            this.DeleteButton.Text = "C";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // GoodsButton
            // 
            this.GoodsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GoodsButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GoodsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GoodsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoodsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodsButton.ForeColor = System.Drawing.Color.White;
            this.GoodsButton.Location = new System.Drawing.Point(25, 432);
            this.GoodsButton.Name = "GoodsButton";
            this.GoodsButton.Size = new System.Drawing.Size(170, 58);
            this.GoodsButton.TabIndex = 220;
            this.GoodsButton.Text = "Goods";
            this.GoodsButton.UseVisualStyleBackColor = false;
            this.GoodsButton.Click += new System.EventHandler(this.GoodsButton_Click);
            // 
            // CardButton
            // 
            this.CardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CardButton.BackColor = System.Drawing.Color.DarkOrange;
            this.CardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CardButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardButton.ForeColor = System.Drawing.Color.White;
            this.CardButton.Location = new System.Drawing.Point(701, 499);
            this.CardButton.Name = "CardButton";
            this.CardButton.Size = new System.Drawing.Size(184, 55);
            this.CardButton.TabIndex = 219;
            this.CardButton.Text = "Card";
            this.CardButton.UseVisualStyleBackColor = false;
            // 
            // CouponButton
            // 
            this.CouponButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CouponButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CouponButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CouponButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CouponButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CouponButton.ForeColor = System.Drawing.Color.White;
            this.CouponButton.Location = new System.Drawing.Point(25, 369);
            this.CouponButton.Name = "CouponButton";
            this.CouponButton.Size = new System.Drawing.Size(170, 58);
            this.CouponButton.TabIndex = 218;
            this.CouponButton.Text = "Coupon";
            this.CouponButton.UseVisualStyleBackColor = false;
            this.CouponButton.Click += new System.EventHandler(this.CouponButton_Click_1);
            // 
            // NrEightButton
            // 
            this.NrEightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NrEightButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NrEightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NrEightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NrEightButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrEightButton.ForeColor = System.Drawing.Color.White;
            this.NrEightButton.Location = new System.Drawing.Point(499, 433);
            this.NrEightButton.Name = "NrEightButton";
            this.NrEightButton.Size = new System.Drawing.Size(97, 58);
            this.NrEightButton.TabIndex = 217;
            this.NrEightButton.Text = "8";
            this.NrEightButton.UseVisualStyleBackColor = false;
            this.NrEightButton.Click += new System.EventHandler(this.NrEightButton_Click);
            // 
            // NrNineButton
            // 
            this.NrNineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NrNineButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NrNineButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NrNineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NrNineButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrNineButton.ForeColor = System.Drawing.Color.White;
            this.NrNineButton.Location = new System.Drawing.Point(599, 433);
            this.NrNineButton.Name = "NrNineButton";
            this.NrNineButton.Size = new System.Drawing.Size(97, 58);
            this.NrNineButton.TabIndex = 216;
            this.NrNineButton.Text = "9";
            this.NrNineButton.UseVisualStyleBackColor = false;
            this.NrNineButton.Click += new System.EventHandler(this.NrNineButton_Click);
            // 
            // NrTwoButton
            // 
            this.NrTwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NrTwoButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NrTwoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NrTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NrTwoButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrTwoButton.ForeColor = System.Drawing.Color.White;
            this.NrTwoButton.Location = new System.Drawing.Point(499, 561);
            this.NrTwoButton.Name = "NrTwoButton";
            this.NrTwoButton.Size = new System.Drawing.Size(97, 58);
            this.NrTwoButton.TabIndex = 215;
            this.NrTwoButton.Text = "2";
            this.NrTwoButton.UseVisualStyleBackColor = false;
            this.NrTwoButton.Click += new System.EventHandler(this.NrTwoButton_Click_1);
            // 
            // NrThreeButton
            // 
            this.NrThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NrThreeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NrThreeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NrThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NrThreeButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrThreeButton.ForeColor = System.Drawing.Color.White;
            this.NrThreeButton.Location = new System.Drawing.Point(599, 561);
            this.NrThreeButton.Name = "NrThreeButton";
            this.NrThreeButton.Size = new System.Drawing.Size(97, 58);
            this.NrThreeButton.TabIndex = 214;
            this.NrThreeButton.Text = "3";
            this.NrThreeButton.UseVisualStyleBackColor = false;
            this.NrThreeButton.Click += new System.EventHandler(this.NrThreeButton_Click);
            // 
            // nrFourButton
            // 
            this.nrFourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nrFourButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nrFourButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nrFourButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nrFourButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrFourButton.ForeColor = System.Drawing.Color.White;
            this.nrFourButton.Location = new System.Drawing.Point(399, 497);
            this.nrFourButton.Name = "nrFourButton";
            this.nrFourButton.Size = new System.Drawing.Size(97, 58);
            this.nrFourButton.TabIndex = 213;
            this.nrFourButton.Text = "4";
            this.nrFourButton.UseVisualStyleBackColor = false;
            this.nrFourButton.Click += new System.EventHandler(this.NrFourButton_Click_1);
            // 
            // nrFiveButton
            // 
            this.nrFiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nrFiveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nrFiveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nrFiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nrFiveButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrFiveButton.ForeColor = System.Drawing.Color.White;
            this.nrFiveButton.Location = new System.Drawing.Point(499, 497);
            this.nrFiveButton.Name = "nrFiveButton";
            this.nrFiveButton.Size = new System.Drawing.Size(97, 58);
            this.nrFiveButton.TabIndex = 212;
            this.nrFiveButton.Text = "5";
            this.nrFiveButton.UseVisualStyleBackColor = false;
            this.nrFiveButton.Click += new System.EventHandler(this.NrFiveButton_Click);
            // 
            // NrSixButton
            // 
            this.NrSixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NrSixButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NrSixButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NrSixButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NrSixButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrSixButton.ForeColor = System.Drawing.Color.White;
            this.NrSixButton.Location = new System.Drawing.Point(599, 497);
            this.NrSixButton.Name = "NrSixButton";
            this.NrSixButton.Size = new System.Drawing.Size(97, 58);
            this.NrSixButton.TabIndex = 211;
            this.NrSixButton.Text = "6";
            this.NrSixButton.UseVisualStyleBackColor = false;
            this.NrSixButton.Click += new System.EventHandler(this.NrSixButton_Click);
            // 
            // NrSevenButton
            // 
            this.NrSevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NrSevenButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NrSevenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NrSevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NrSevenButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrSevenButton.ForeColor = System.Drawing.Color.White;
            this.NrSevenButton.Location = new System.Drawing.Point(399, 433);
            this.NrSevenButton.Name = "NrSevenButton";
            this.NrSevenButton.Size = new System.Drawing.Size(97, 58);
            this.NrSevenButton.TabIndex = 210;
            this.NrSevenButton.Text = "7";
            this.NrSevenButton.UseVisualStyleBackColor = false;
            this.NrSevenButton.Click += new System.EventHandler(this.NrSevenButton_Click);
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiptButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReceiptButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReceiptButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptButton.ForeColor = System.Drawing.Color.White;
            this.ReceiptButton.Location = new System.Drawing.Point(892, 583);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(184, 100);
            this.ReceiptButton.TabIndex = 209;
            this.ReceiptButton.Text = "Receipt";
            this.ReceiptButton.UseVisualStyleBackColor = false;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // CashButton
            // 
            this.CashButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CashButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CashButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CashButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CashButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashButton.ForeColor = System.Drawing.Color.White;
            this.CashButton.Location = new System.Drawing.Point(701, 560);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(184, 123);
            this.CashButton.TabIndex = 208;
            this.CashButton.Text = "Cash";
            this.CashButton.UseVisualStyleBackColor = false;
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click_1);
            // 
            // CommaButton
            // 
            this.CommaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CommaButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CommaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CommaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CommaButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommaButton.ForeColor = System.Drawing.Color.White;
            this.CommaButton.Location = new System.Drawing.Point(599, 625);
            this.CommaButton.Name = "CommaButton";
            this.CommaButton.Size = new System.Drawing.Size(97, 58);
            this.CommaButton.TabIndex = 207;
            this.CommaButton.Text = ",";
            this.CommaButton.UseVisualStyleBackColor = false;
            this.CommaButton.Click += new System.EventHandler(this.CommaButton_Click);
            // 
            // NrOneButton
            // 
            this.NrOneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NrOneButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NrOneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NrOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NrOneButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrOneButton.ForeColor = System.Drawing.Color.White;
            this.NrOneButton.Location = new System.Drawing.Point(399, 561);
            this.NrOneButton.Name = "NrOneButton";
            this.NrOneButton.Size = new System.Drawing.Size(97, 58);
            this.NrOneButton.TabIndex = 206;
            this.NrOneButton.Text = "1";
            this.NrOneButton.UseVisualStyleBackColor = false;
            this.NrOneButton.Click += new System.EventHandler(this.NrOneButton_Click_1);
            // 
            // DoubleZeroButton
            // 
            this.DoubleZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DoubleZeroButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DoubleZeroButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DoubleZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoubleZeroButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleZeroButton.ForeColor = System.Drawing.Color.White;
            this.DoubleZeroButton.Location = new System.Drawing.Point(499, 625);
            this.DoubleZeroButton.Name = "DoubleZeroButton";
            this.DoubleZeroButton.Size = new System.Drawing.Size(97, 58);
            this.DoubleZeroButton.TabIndex = 205;
            this.DoubleZeroButton.Text = "00";
            this.DoubleZeroButton.UseVisualStyleBackColor = false;
            this.DoubleZeroButton.Click += new System.EventHandler(this.DoubleZeroButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZeroButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZeroButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZeroButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(399, 625);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(97, 58);
            this.ZeroButton.TabIndex = 204;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // momsButton
            // 
            this.momsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.momsButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.momsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.momsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.momsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.momsButton.ForeColor = System.Drawing.Color.White;
            this.momsButton.Location = new System.Drawing.Point(25, 561);
            this.momsButton.Name = "momsButton";
            this.momsButton.Size = new System.Drawing.Size(170, 58);
            this.momsButton.TabIndex = 203;
            this.momsButton.Text = "Moms";
            this.momsButton.UseVisualStyleBackColor = false;
            this.momsButton.Click += new System.EventHandler(this.MomsButton_Click);
            // 
            // DiscountButton
            // 
            this.DiscountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DiscountButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DiscountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DiscountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DiscountButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountButton.ForeColor = System.Drawing.Color.White;
            this.DiscountButton.Location = new System.Drawing.Point(25, 497);
            this.DiscountButton.Name = "DiscountButton";
            this.DiscountButton.Size = new System.Drawing.Size(170, 58);
            this.DiscountButton.TabIndex = 202;
            this.DiscountButton.Text = "Discount";
            this.DiscountButton.UseVisualStyleBackColor = false;
            this.DiscountButton.Click += new System.EventHandler(this.DiscountButton__Click);
            // 
            // ClearBotton
            // 
            this.ClearBotton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearBotton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearBotton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBotton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBotton.ForeColor = System.Drawing.Color.White;
            this.ClearBotton.Location = new System.Drawing.Point(25, 625);
            this.ClearBotton.Name = "ClearBotton";
            this.ClearBotton.Size = new System.Drawing.Size(170, 58);
            this.ClearBotton.TabIndex = 201;
            this.ClearBotton.Text = "Clear";
            this.ClearBotton.UseVisualStyleBackColor = false;
            this.ClearBotton.Click += new System.EventHandler(this.ClearBotton_Click);
            // 
            // toPayLabel
            // 
            this.toPayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toPayLabel.AutoSize = true;
            this.toPayLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPayLabel.Location = new System.Drawing.Point(824, 312);
            this.toPayLabel.Name = "toPayLabel";
            this.toPayLabel.Size = new System.Drawing.Size(113, 33);
            this.toPayLabel.TabIndex = 200;
            this.toPayLabel.Text = "To pay....";
            // 
            // couponLabel
            // 
            this.couponLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.couponLabel.AutoSize = true;
            this.couponLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponLabel.Location = new System.Drawing.Point(820, 201);
            this.couponLabel.Name = "couponLabel";
            this.couponLabel.Size = new System.Drawing.Size(117, 33);
            this.couponLabel.TabIndex = 199;
            this.couponLabel.Text = "Coupon....";
            // 
            // couponTextBox
            // 
            this.couponTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.couponTextBox.Location = new System.Drawing.Point(944, 212);
            this.couponTextBox.Name = "couponTextBox";
            this.couponTextBox.Size = new System.Drawing.Size(132, 22);
            this.couponTextBox.TabIndex = 196;
            this.couponTextBox.Text = "0.00";
            this.couponTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toPayTextBox
            // 
            this.toPayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toPayTextBox.Location = new System.Drawing.Point(944, 323);
            this.toPayTextBox.Name = "toPayTextBox";
            this.toPayTextBox.Size = new System.Drawing.Size(132, 22);
            this.toPayTextBox.TabIndex = 195;
            this.toPayTextBox.Text = "0.00";
            this.toPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountLabel
            // 
            this.discountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(802, 234);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(135, 33);
            this.discountLabel.TabIndex = 192;
            this.discountLabel.Text = "Discount....";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountTextBox.Location = new System.Drawing.Point(944, 244);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(132, 22);
            this.discountTextBox.TabIndex = 191;
            this.discountTextBox.Text = "0.00";
            this.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountTextBox.TextChanged += new System.EventHandler(this.DiscountTextBox_TextChanged);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTextBox.Location = new System.Drawing.Point(944, 146);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(132, 22);
            this.totalTextBox.TabIndex = 190;
            this.totalTextBox.Text = "0.00";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalTextBox.TextChanged += new System.EventHandler(this.TotalTextBox_TextChanged);
            // 
            // changeLabel
            // 
            this.changeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(821, 168);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(116, 33);
            this.changeLabel.TabIndex = 189;
            this.changeLabel.Text = "change....";
            // 
            // idNrTextBox
            // 
            this.idNrTextBox.Location = new System.Drawing.Point(440, 17);
            this.idNrTextBox.Name = "idNrTextBox";
            this.idNrTextBox.Size = new System.Drawing.Size(70, 22);
            this.idNrTextBox.TabIndex = 187;
            this.idNrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // idNrLabel
            // 
            this.idNrLabel.AutoSize = true;
            this.idNrLabel.Location = new System.Drawing.Point(393, 20);
            this.idNrLabel.Name = "idNrLabel";
            this.idNrLabel.Size = new System.Drawing.Size(48, 17);
            this.idNrLabel.TabIndex = 184;
            this.idNrLabel.Text = "ID Nr: ";
            // 
            // reciptNrLabel
            // 
            this.reciptNrLabel.AutoSize = true;
            this.reciptNrLabel.Location = new System.Drawing.Point(29, 18);
            this.reciptNrLabel.Name = "reciptNrLabel";
            this.reciptNrLabel.Size = new System.Drawing.Size(79, 17);
            this.reciptNrLabel.TabIndex = 182;
            this.reciptNrLabel.Text = "ReceiptNr: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(821, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 239;
            this.label1.Text = "Search....";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(944, 53);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(131, 22);
            this.searchTextBox.TabIndex = 240;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // momsTextBox
            // 
            this.momsTextBox.Location = new System.Drawing.Point(944, 285);
            this.momsTextBox.Name = "momsTextBox";
            this.momsTextBox.Size = new System.Drawing.Size(131, 22);
            this.momsTextBox.TabIndex = 242;
            this.momsTextBox.Text = "0.00";
            this.momsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // momsLabel
            // 
            this.momsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.momsLabel.AutoSize = true;
            this.momsLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.momsLabel.Location = new System.Drawing.Point(834, 279);
            this.momsLabel.Name = "momsLabel";
            this.momsLabel.Size = new System.Drawing.Size(103, 33);
            this.momsLabel.TabIndex = 241;
            this.momsLabel.Text = "Moms....";
            // 
            // changeTextBox
            // 
            this.changeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeTextBox.Location = new System.Drawing.Point(944, 180);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.Size = new System.Drawing.Size(132, 22);
            this.changeTextBox.TabIndex = 244;
            this.changeTextBox.Text = "0.00";
            this.changeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(840, 135);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(97, 33);
            this.totalLabel.TabIndex = 243;
            this.totalLabel.Text = "Total....";
            // 
            // idnameComboBox
            // 
            this.idnameComboBox.DisplayMember = "fName";
            this.idnameComboBox.FormattingEnabled = true;
            this.idnameComboBox.Location = new System.Drawing.Point(516, 16);
            this.idnameComboBox.Name = "idnameComboBox";
            this.idnameComboBox.Size = new System.Drawing.Size(286, 24);
            this.idnameComboBox.TabIndex = 245;
            this.idnameComboBox.ValueMember = "sName";
            // 
            // goodsListView
            // 
            this.goodsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.goodsListView.FullRowSelect = true;
            this.goodsListView.GridLines = true;
            this.goodsListView.Location = new System.Drawing.Point(32, 53);
            this.goodsListView.MultiSelect = false;
            this.goodsListView.Name = "goodsListView";
            this.goodsListView.Size = new System.Drawing.Size(770, 310);
            this.goodsListView.TabIndex = 246;
            this.goodsListView.UseCompatibleStateImageBehavior = false;
            this.goodsListView.View = System.Windows.Forms.View.Details;
            this.goodsListView.SelectedIndexChanged += new System.EventHandler(this.GoodsListView_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductId";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Group";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Qty";
            // 
            // btn_subtract
            // 
            this.btn_subtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_subtract.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_subtract.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_subtract.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtract.ForeColor = System.Drawing.Color.White;
            this.btn_subtract.Location = new System.Drawing.Point(399, 371);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(97, 58);
            this.btn_subtract.TabIndex = 247;
            this.btn_subtract.Text = "-";
            this.btn_subtract.UseVisualStyleBackColor = false;
            this.btn_subtract.Click += new System.EventHandler(this.Btn_subtract_Click);
            // 
            // pnl_Amount
            // 
            this.pnl_Amount.Controls.Add(this.lbl_CashAmount);
            this.pnl_Amount.Controls.Add(this.btn_CashOk);
            this.pnl_Amount.Controls.Add(this.txtb_CashAmount);
            this.pnl_Amount.Location = new System.Drawing.Point(396, 135);
            this.pnl_Amount.Name = "pnl_Amount";
            this.pnl_Amount.Size = new System.Drawing.Size(200, 131);
            this.pnl_Amount.TabIndex = 248;
            // 
            // lbl_CashAmount
            // 
            this.lbl_CashAmount.AutoSize = true;
            this.lbl_CashAmount.Location = new System.Drawing.Point(53, 14);
            this.lbl_CashAmount.Name = "lbl_CashAmount";
            this.lbl_CashAmount.Size = new System.Drawing.Size(94, 17);
            this.lbl_CashAmount.TabIndex = 2;
            this.lbl_CashAmount.Text = "Enter Amount";
            // 
            // btn_CashOk
            // 
            this.btn_CashOk.Location = new System.Drawing.Point(68, 89);
            this.btn_CashOk.Name = "btn_CashOk";
            this.btn_CashOk.Size = new System.Drawing.Size(75, 23);
            this.btn_CashOk.TabIndex = 1;
            this.btn_CashOk.Text = "Ok";
            this.btn_CashOk.UseVisualStyleBackColor = true;
            this.btn_CashOk.Click += new System.EventHandler(this.Btn_AmountOk_Click);
            // 
            // txtb_CashAmount
            // 
            this.txtb_CashAmount.Location = new System.Drawing.Point(31, 41);
            this.txtb_CashAmount.Name = "txtb_CashAmount";
            this.txtb_CashAmount.Size = new System.Drawing.Size(142, 22);
            this.txtb_CashAmount.TabIndex = 0;
            // 
            // deletRowBotton
            // 
            this.deletRowBotton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletRowBotton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletRowBotton.ForeColor = System.Drawing.Color.White;
            this.deletRowBotton.Location = new System.Drawing.Point(499, 369);
            this.deletRowBotton.Name = "deletRowBotton";
            this.deletRowBotton.Size = new System.Drawing.Size(197, 60);
            this.deletRowBotton.TabIndex = 249;
            this.deletRowBotton.Text = "Delet Row";
            this.deletRowBotton.UseVisualStyleBackColor = false;
            this.deletRowBotton.Click += new System.EventHandler(this.DeletRowbotton);
            // 
            // reciptNrTextBox
            // 
            this.reciptNrTextBox.Location = new System.Drawing.Point(104, 17);
            this.reciptNrTextBox.Multiline = true;
            this.reciptNrTextBox.Name = "reciptNrTextBox";
            this.reciptNrTextBox.Size = new System.Drawing.Size(258, 22);
            this.reciptNrTextBox.TabIndex = 250;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 696);
            this.Controls.Add(this.reciptNrTextBox);
            this.Controls.Add(this.deletRowBotton);
            this.Controls.Add(this.btn_subtract);
            this.Controls.Add(this.goodsListView);
            this.Controls.Add(this.idnameComboBox);
            this.Controls.Add(this.changeTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.momsTextBox);
            this.Controls.Add(this.momsLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tenPercentButton);
            this.Controls.Add(this.twentyPercentButton);
            this.Controls.Add(this.TimesButton);
            this.Controls.Add(this.thertyPercentButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BarcodeBotton);
            this.Controls.Add(this.OkBotton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.GoodsButton);
            this.Controls.Add(this.CardButton);
            this.Controls.Add(this.CouponButton);
            this.Controls.Add(this.NrEightButton);
            this.Controls.Add(this.NrNineButton);
            this.Controls.Add(this.NrTwoButton);
            this.Controls.Add(this.NrThreeButton);
            this.Controls.Add(this.nrFourButton);
            this.Controls.Add(this.nrFiveButton);
            this.Controls.Add(this.NrSixButton);
            this.Controls.Add(this.NrSevenButton);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.CashButton);
            this.Controls.Add(this.CommaButton);
            this.Controls.Add(this.NrOneButton);
            this.Controls.Add(this.DoubleZeroButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.momsButton);
            this.Controls.Add(this.DiscountButton);
            this.Controls.Add(this.ClearBotton);
            this.Controls.Add(this.toPayLabel);
            this.Controls.Add(this.couponLabel);
            this.Controls.Add(this.couponTextBox);
            this.Controls.Add(this.toPayTextBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.idNrTextBox);
            this.Controls.Add(this.idNrLabel);
            this.Controls.Add(this.reciptNrLabel);
            this.Controls.Add(this.pnl_Amount);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Kassa";
            this.pnl_Amount.ResumeLayout(false);
            this.pnl_Amount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Calculator_Load_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CashButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CouponButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GoodsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button tenPercentButton;
        private System.Windows.Forms.Button twentyPercentButton;
        private System.Windows.Forms.Button TimesButton;
        private System.Windows.Forms.Button thertyPercentButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button BarcodeBotton;
        private System.Windows.Forms.Button OkBotton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button GoodsButton;
        private System.Windows.Forms.Button CardButton;
        private System.Windows.Forms.Button CouponButton;
        private System.Windows.Forms.Button NrEightButton;
        private System.Windows.Forms.Button NrNineButton;
        private System.Windows.Forms.Button NrTwoButton;
        private System.Windows.Forms.Button NrThreeButton;
        private System.Windows.Forms.Button nrFourButton;
        private System.Windows.Forms.Button nrFiveButton;
        private System.Windows.Forms.Button NrSixButton;
        private System.Windows.Forms.Button NrSevenButton;
        private System.Windows.Forms.Button ReceiptButton;
        private System.Windows.Forms.Button CashButton;
        private System.Windows.Forms.Button CommaButton;
        private System.Windows.Forms.Button NrOneButton;
        private System.Windows.Forms.Button DoubleZeroButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button momsButton;
        private System.Windows.Forms.Button DiscountButton;
        private System.Windows.Forms.Button ClearBotton;
        private System.Windows.Forms.Label toPayLabel;
        private System.Windows.Forms.Label couponLabel;
        private System.Windows.Forms.TextBox couponTextBox;
        private System.Windows.Forms.TextBox toPayTextBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.TextBox idNrTextBox;
        private System.Windows.Forms.Label idNrLabel;
        private System.Windows.Forms.Label reciptNrLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.TextBox momsTextBox;
        private System.Windows.Forms.Label momsLabel;
        private System.Windows.Forms.TextBox changeTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ComboBox idnameComboBox;
        private System.Windows.Forms.ListView goodsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Panel pnl_Amount;
        private System.Windows.Forms.Label lbl_CashAmount;
        private System.Windows.Forms.Button btn_CashOk;
        private System.Windows.Forms.TextBox txtb_CashAmount;
        private Button deletRowBotton;
        private TextBox reciptNrTextBox;

        private BindingSource employeeBindingSource1;


        public EventHandler CommaButton_Click_1 { get; private set; }
        public EventHandler DeleteButton_Click_1 { get; private set; }
        public EventHandler DiscountButton_Click { get; private set; }
        public EventHandler discountTextBox_TextChanged { get; private set; }
        public EventHandler DoubleZeroButton_Click_1 { get; private set; }
        public EventHandler NrEightButton_Click_1 { get; private set; }
        public EventHandler nrFiveButton_Click_1 { get; private set; }
        public EventHandler nrFourButton_Click_1 { get; private set; }
        public EventHandler NrNineButton_Click_1 { get; private set; }
        public EventHandler nrSearchButton_Click { get; private set; }
        public EventHandler NrSevenButton_Click_1 { get; private set; }
        public EventHandler NrSixButton_Click_1 { get; private set; }
        public EventHandler OkBotton_Click { get; private set; }
        public EventHandler PlusButton_Click_1 { get; private set; }
        public EventHandler searchTextBox_TextChanged_1 { get; private set; }
        public EventHandler tenPercentButton_Click { get; private set; }
        public EventHandler textBox2_TextChanged { get; private set; }
        public EventHandler thertyPercentButton_Click { get; private set; }
        public EventHandler TimesButton_Click_1 { get; private set; }
        public EventHandler toPayTextBox_TextChanged { get; private set; }
        public EventHandler totalTextBox_TextChanged { get; private set; }
        public EventHandler twentyPercentButton_Click { get; private set; }
        public EventHandler ZeroButton_Click_1 { get; private set; }
    }
}

