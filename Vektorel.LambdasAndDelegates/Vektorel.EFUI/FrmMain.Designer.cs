namespace Vektorel.EFUI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAll = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label4 = new Label();
            nudStock = new NumericUpDown();
            nudPrice = new NumericUpDown();
            txtProductName = new TextBox();
            label3 = new Label();
            btnSaveProduct = new Button();
            cmbSuppliers = new ComboBox();
            label1 = new Label();
            btnCrticalStock = new Button();
            btnBeverages = new Button();
            btnUSASuppliers = new Button();
            btnProductInfo = new Button();
            btnCategorySale = new Button();
            btnEmployeeSales = new Button();
            button7 = new Button();
            button8 = new Button();
            label2 = new Label();
            cmbCategories = new ComboBox();
            groupBox2 = new GroupBox();
            btnSaveSupplier = new Button();
            txtCity = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtCountry = new TextBox();
            txtPhone = new TextBox();
            txtManager = new TextBox();
            txtCompany = new TextBox();
            btnReadAndUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAll).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAll
            // 
            dgvAll.AllowUserToAddRows = false;
            dgvAll.AllowUserToDeleteRows = false;
            dgvAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAll.Location = new Point(12, 41);
            dgvAll.MultiSelect = false;
            dgvAll.Name = "dgvAll";
            dgvAll.ReadOnly = true;
            dgvAll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAll.Size = new Size(409, 399);
            dgvAll.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudStock);
            groupBox1.Controls.Add(nudPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSaveProduct);
            groupBox1.Location = new Point(427, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 185);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Bilgisi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 107);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 63);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 9;
            label4.Text = "Fiyat";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(6, 125);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(188, 23);
            nudStock.TabIndex = 8;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(6, 81);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(188, 23);
            nudPrice.TabIndex = 7;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(6, 37);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(188, 23);
            txtProductName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Ürün Adı";
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.Location = new Point(119, 154);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(75, 23);
            btnSaveProduct.TabIndex = 0;
            btnSaveProduct.Text = "Kaydet";
            btnSaveProduct.UseVisualStyleBackColor = true;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(84, 12);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(293, 23);
            cmbSuppliers.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Tedarikçiler";
            // 
            // btnCrticalStock
            // 
            btnCrticalStock.Location = new Point(12, 446);
            btnCrticalStock.Name = "btnCrticalStock";
            btnCrticalStock.Size = new Size(122, 23);
            btnCrticalStock.TabIndex = 4;
            btnCrticalStock.Text = "Kritik Stok Seviyesi";
            btnCrticalStock.UseVisualStyleBackColor = true;
            btnCrticalStock.Click += btnCrticalStock_Click;
            // 
            // btnBeverages
            // 
            btnBeverages.Location = new Point(12, 475);
            btnBeverages.Name = "btnBeverages";
            btnBeverages.Size = new Size(122, 23);
            btnBeverages.TabIndex = 5;
            btnBeverages.Text = "İçecekler";
            btnBeverages.UseVisualStyleBackColor = true;
            btnBeverages.Click += btnBeverages_Click;
            // 
            // btnUSASuppliers
            // 
            btnUSASuppliers.Location = new Point(140, 446);
            btnUSASuppliers.Name = "btnUSASuppliers";
            btnUSASuppliers.Size = new Size(122, 23);
            btnUSASuppliers.TabIndex = 6;
            btnUSASuppliers.Text = "ABD Tedarikçileri";
            btnUSASuppliers.UseVisualStyleBackColor = true;
            btnUSASuppliers.Click += btnUSASuppliers_Click;
            // 
            // btnProductInfo
            // 
            btnProductInfo.Location = new Point(140, 475);
            btnProductInfo.Name = "btnProductInfo";
            btnProductInfo.Size = new Size(122, 23);
            btnProductInfo.TabIndex = 7;
            btnProductInfo.Text = "Ürün Tipi Tedarikçisi";
            btnProductInfo.UseVisualStyleBackColor = true;
            btnProductInfo.Click += btnProductInfo_Click;
            // 
            // btnCategorySale
            // 
            btnCategorySale.Location = new Point(268, 475);
            btnCategorySale.Name = "btnCategorySale";
            btnCategorySale.Size = new Size(122, 23);
            btnCategorySale.TabIndex = 9;
            btnCategorySale.Text = "1998 Kategori Satışı";
            btnCategorySale.UseVisualStyleBackColor = true;
            btnCategorySale.Click += btnCategorySale_Click;
            // 
            // btnEmployeeSales
            // 
            btnEmployeeSales.Location = new Point(268, 446);
            btnEmployeeSales.Name = "btnEmployeeSales";
            btnEmployeeSales.Size = new Size(122, 23);
            btnEmployeeSales.TabIndex = 8;
            btnEmployeeSales.Text = "Çalışan Satışları";
            btnEmployeeSales.UseVisualStyleBackColor = true;
            btnEmployeeSales.Click += btnEmployeeSales_Click;
            // 
            // button7
            // 
            button7.Location = new Point(396, 475);
            button7.Name = "button7";
            button7.Size = new Size(122, 23);
            button7.TabIndex = 11;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(396, 446);
            button8.Name = "button8";
            button8.Size = new Size(122, 23);
            button8.TabIndex = 10;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 15);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 12;
            label2.Text = "Ürün Türleri";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(458, 12);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(169, 23);
            cmbCategories.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnReadAndUpdate);
            groupBox2.Controls.Add(btnSaveSupplier);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCountry);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtManager);
            groupBox2.Controls.Add(txtCompany);
            groupBox2.Location = new Point(427, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 208);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tedarikçi Bilgisi";
            // 
            // btnSaveSupplier
            // 
            btnSaveSupplier.Location = new Point(119, 168);
            btnSaveSupplier.Name = "btnSaveSupplier";
            btnSaveSupplier.Size = new Size(75, 23);
            btnSaveSupplier.TabIndex = 29;
            btnSaveSupplier.Text = "Kaydet";
            btnSaveSupplier.UseVisualStyleBackColor = true;
            btnSaveSupplier.Click += btnSaveSupplier_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(61, 139);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(133, 23);
            txtCity.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 142);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 27;
            label11.Text = "Şehir";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 113);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 26;
            label10.Text = "Ülke";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 86);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 25;
            label9.Text = "Telefon";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 57);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 24;
            label8.Text = "Yönetici";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 28);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 23;
            label7.Text = "Firma";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(61, 110);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(133, 23);
            txtCountry.TabIndex = 22;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(61, 83);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(133, 23);
            txtPhone.TabIndex = 21;
            // 
            // txtManager
            // 
            txtManager.Location = new Point(61, 54);
            txtManager.Name = "txtManager";
            txtManager.Size = new Size(133, 23);
            txtManager.TabIndex = 20;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(61, 25);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(133, 23);
            txtCompany.TabIndex = 19;
            // 
            // btnReadAndUpdate
            // 
            btnReadAndUpdate.Location = new Point(38, 168);
            btnReadAndUpdate.Name = "btnReadAndUpdate";
            btnReadAndUpdate.Size = new Size(75, 23);
            btnReadAndUpdate.TabIndex = 30;
            btnReadAndUpdate.Text = "Kayıt Getir";
            btnReadAndUpdate.UseVisualStyleBackColor = true;
            btnReadAndUpdate.Click += btnReadAndUpdate_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 502);
            Controls.Add(groupBox2);
            Controls.Add(cmbCategories);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(btnCategorySale);
            Controls.Add(btnEmployeeSales);
            Controls.Add(btnProductInfo);
            Controls.Add(btnUSASuppliers);
            Controls.Add(btnBeverages);
            Controls.Add(btnCrticalStock);
            Controls.Add(label1);
            Controls.Add(cmbSuppliers);
            Controls.Add(groupBox1);
            Controls.Add(dgvAll);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "Northwind";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAll).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAll;
        private GroupBox groupBox1;
        private ComboBox cmbSuppliers;
        private Label label1;
        private Button btnCrticalStock;
        private Button btnBeverages;
        private Button btnUSASuppliers;
        private Button btnProductInfo;
        private Button btnCategorySale;
        private Button btnEmployeeSales;
        private Button button7;
        private Button button8;
        private Label label2;
        private ComboBox cmbCategories;
        private Label label6;
        private Label label4;
        private NumericUpDown nudStock;
        private NumericUpDown nudPrice;
        private TextBox txtProductName;
        private Label label3;
        private Button btnSaveProduct;
        private GroupBox groupBox2;
        private Button btnSaveSupplier;
        private TextBox txtCity;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtCountry;
        private TextBox txtPhone;
        private TextBox txtManager;
        private TextBox txtCompany;
        private Button btnReadAndUpdate;
    }
}
