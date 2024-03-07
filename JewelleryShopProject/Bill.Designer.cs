namespace JewelleryShopProject
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddtobill = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelitem = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itemDVG = new System.Windows.Forms.DataGridView();
            this.buttonprint = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.BillDVG = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerDVG = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.itemDVG);
            this.panel1.Controls.Add(this.buttonprint);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.BillDVG);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CustomerDVG);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Location = new System.Drawing.Point(27, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 679);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxCustomerName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxprice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonAddtobill);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxQuantity);
            this.panel2.Controls.Add(this.textBoxProductName);
            this.panel2.Controls.Add(this.labelitem);
            this.panel2.Location = new System.Drawing.Point(3, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 254);
            this.panel2.TabIndex = 29;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(56, 147);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(124, 22);
            this.textBoxCustomerName.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Customer Name";
            // 
            // textBoxprice
            // 
            this.textBoxprice.Enabled = false;
            this.textBoxprice.Location = new System.Drawing.Point(245, 147);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(124, 22);
            this.textBoxprice.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Price";
            // 
            // buttonAddtobill
            // 
            this.buttonAddtobill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddtobill.Location = new System.Drawing.Point(9, 194);
            this.buttonAddtobill.Name = "buttonAddtobill";
            this.buttonAddtobill.Size = new System.Drawing.Size(171, 48);
            this.buttonAddtobill.TabIndex = 29;
            this.buttonAddtobill.Text = "Add To Bill";
            this.buttonAddtobill.UseVisualStyleBackColor = true;
            this.buttonAddtobill.Click += new System.EventHandler(this.buttonAddtobill_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(218, 194);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(128, 48);
            this.buttonReset.TabIndex = 28;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(245, 85);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(124, 22);
            this.textBoxQuantity.TabIndex = 24;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Enabled = false;
            this.textBoxProductName.Location = new System.Drawing.Point(56, 85);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(124, 22);
            this.textBoxProductName.TabIndex = 23;
            // 
            // labelitem
            // 
            this.labelitem.AutoSize = true;
            this.labelitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelitem.Location = new System.Drawing.Point(52, 62);
            this.labelitem.Name = "labelitem";
            this.labelitem.Size = new System.Drawing.Size(128, 20);
            this.labelitem.TabIndex = 22;
            this.labelitem.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(738, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = "Products  List";
            // 
            // itemDVG
            // 
            this.itemDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDVG.Location = new System.Drawing.Point(600, 418);
            this.itemDVG.Name = "itemDVG";
            this.itemDVG.RowHeadersWidth = 51;
            this.itemDVG.RowTemplate.Height = 24;
            this.itemDVG.Size = new System.Drawing.Size(597, 245);
            this.itemDVG.TabIndex = 27;
            this.itemDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDVG_CellContentClick);
            // 
            // buttonprint
            // 
            this.buttonprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonprint.Location = new System.Drawing.Point(970, 343);
            this.buttonprint.Name = "buttonprint";
            this.buttonprint.Size = new System.Drawing.Size(128, 35);
            this.buttonprint.TabIndex = 26;
            this.buttonprint.Text = "Print";
            this.buttonprint.UseVisualStyleBackColor = true;
            this.buttonprint.Click += new System.EventHandler(this.buttonprint_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(703, 340);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(93, 32);
            this.lbltotal.TabIndex = 25;
            this.lbltotal.Text = "Total:";
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // BillDVG
            // 
            this.BillDVG.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.BillDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Column1,
            this.Price,
            this.Quantity,
            this.Total});
            this.BillDVG.Location = new System.Drawing.Point(494, 80);
            this.BillDVG.Name = "BillDVG";
            this.BillDVG.RowHeadersWidth = 51;
            this.BillDVG.RowTemplate.Height = 24;
            this.BillDVG.Size = new System.Drawing.Size(779, 212);
            this.BillDVG.TabIndex = 24;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(824, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Customers  List";
            // 
            // CustomerDVG
            // 
            this.CustomerDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDVG.Location = new System.Drawing.Point(48, 418);
            this.CustomerDVG.Name = "CustomerDVG";
            this.CustomerDVG.RowHeadersWidth = 51;
            this.CustomerDVG.RowTemplate.Height = 24;
            this.CustomerDVG.Size = new System.Drawing.Size(498, 245);
            this.CustomerDVG.TabIndex = 16;
            this.CustomerDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDVG_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(564, 21);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(101, 32);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Billing";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1377, 738);
            this.Controls.Add(this.panel1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CustomerDVG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView BillDVG;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView itemDVG;
        private System.Windows.Forms.Button buttonprint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddtobill;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelitem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}