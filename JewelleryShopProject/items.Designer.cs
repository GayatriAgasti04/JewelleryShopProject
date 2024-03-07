namespace JewelleryShopProject
{
    partial class items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(items));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.FilterTypes = new System.Windows.Forms.ComboBox();
            this.FilterCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemDVG = new System.Windows.Forms.DataGridView();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.labelprice = new System.Windows.Forms.Label();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.labelitem = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.FilterTypes);
            this.panel1.Controls.Add(this.FilterCat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.itemDVG);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonsave);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelQuantity);
            this.panel1.Controls.Add(this.textBoxQuantity);
            this.panel1.Controls.Add(this.textBoxprice);
            this.panel1.Controls.Add(this.labelprice);
            this.panel1.Controls.Add(this.comboBoxTypes);
            this.panel1.Controls.Add(this.comboBoxCategories);
            this.panel1.Controls.Add(this.textBoxItems);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.labelitem);
            this.panel1.Controls.Add(this.lblProducts);
            this.panel1.Location = new System.Drawing.Point(49, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 645);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(690, 339);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FilterTypes
            // 
            this.FilterTypes.FormattingEnabled = true;
            this.FilterTypes.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Diamonds"});
            this.FilterTypes.Location = new System.Drawing.Point(563, 350);
            this.FilterTypes.Name = "FilterTypes";
            this.FilterTypes.Size = new System.Drawing.Size(121, 24);
            this.FilterTypes.TabIndex = 19;
            this.FilterTypes.Text = "Types";
            this.FilterTypes.SelectionChangeCommitted += new System.EventHandler(this.FilterTypes_SelectionChangeCommitted);
            // 
            // FilterCat
            // 
            this.FilterCat.FormattingEnabled = true;
            this.FilterCat.Items.AddRange(new object[] {
            "Earing",
            "Ring",
            "Necklance",
            "Bangle",
            "Braceletes",
            "Chain",
            "Pendant",
            "Diamonds",
            "Anklet",
            "Jewelry set",
            "Loket"});
            this.FilterCat.Location = new System.Drawing.Point(343, 350);
            this.FilterCat.Name = "FilterCat";
            this.FilterCat.Size = new System.Drawing.Size(121, 24);
            this.FilterCat.TabIndex = 18;
            this.FilterCat.Text = "Categories";
            this.FilterCat.SelectionChangeCommitted += new System.EventHandler(this.FilterCat_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Products List";
            // 
            // itemDVG
            // 
            this.itemDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDVG.Location = new System.Drawing.Point(98, 412);
            this.itemDVG.Name = "itemDVG";
            this.itemDVG.RowHeadersWidth = 51;
            this.itemDVG.RowTemplate.Height = 24;
            this.itemDVG.Size = new System.Drawing.Size(920, 214);
            this.itemDVG.TabIndex = 16;
            this.itemDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDVG_CellContentClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(841, 270);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(128, 48);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(651, 270);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(128, 48);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(434, 270);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(128, 48);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsave.Location = new System.Drawing.Point(190, 270);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(128, 48);
            this.buttonsave.TabIndex = 12;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(108, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(903, 167);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 20);
            this.labelQuantity.TabIndex = 9;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(894, 190);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(124, 22);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // textBoxprice
            // 
            this.textBoxprice.Location = new System.Drawing.Point(694, 190);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(124, 22);
            this.textBoxprice.TabIndex = 7;
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.Location = new System.Drawing.Point(703, 167);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(53, 20);
            this.labelprice.TabIndex = 6;
            this.labelprice.Text = "Price";
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Diamonds"});
            this.comboBoxTypes.Location = new System.Drawing.Point(486, 188);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTypes.TabIndex = 5;
            this.comboBoxTypes.Text = "Types";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Items.AddRange(new object[] {
            "Earing",
            "Ring",
            "Necklance",
            "Bangle",
            "Braceletes",
            "Chain",
            "Pendant",
            "Diamonds",
            "Anklet",
            "Jewelry set",
            "Loket"});
            this.comboBoxCategories.Location = new System.Drawing.Point(281, 188);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategories.TabIndex = 4;
            this.comboBoxCategories.Text = "Categories";
            // 
            // textBoxItems
            // 
            this.textBoxItems.Location = new System.Drawing.Point(98, 190);
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.Size = new System.Drawing.Size(124, 22);
            this.textBoxItems.TabIndex = 3;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(710, 52);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(145, 32);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // labelitem
            // 
            this.labelitem.AutoSize = true;
            this.labelitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelitem.Location = new System.Drawing.Point(104, 167);
            this.labelitem.Name = "labelitem";
            this.labelitem.Size = new System.Drawing.Size(55, 20);
            this.labelitem.TabIndex = 1;
            this.labelitem.Text = "Items";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(268, 52);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(135, 32);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Products";
            this.lblProducts.Click += new System.EventHandler(this.lblProducts_Click);
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1212, 740);
            this.Controls.Add(this.panel1);
            this.Name = "items";
            this.Text = "items";
            this.Load += new System.EventHandler(this.items_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelitem;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.TextBox textBoxItems;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView itemDVG;
        private System.Windows.Forms.ComboBox FilterTypes;
        private System.Windows.Forms.ComboBox FilterCat;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}