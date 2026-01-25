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
            cmbSuppliers = new ComboBox();
            label1 = new Label();
            btnCrticalStock = new Button();
            btnBeverages = new Button();
            btnUSASuppliers = new Button();
            btnProductInfo = new Button();
            button5 = new Button();
            btnEmployeeSales = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAll).BeginInit();
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
            groupBox1.Location = new Point(427, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 399);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Bilgisi";
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(84, 12);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(337, 23);
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
            // button5
            // 
            button5.Location = new Point(268, 475);
            button5.Name = "button5";
            button5.Size = new Size(122, 23);
            button5.TabIndex = 9;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
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
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 502);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
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
        private Button button5;
        private Button btnEmployeeSales;
        private Button button7;
        private Button button8;
    }
}
