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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            // button3
            // 
            button3.Location = new Point(140, 446);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(140, 475);
            button4.Name = "button4";
            button4.Size = new Size(122, 23);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
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
            // button6
            // 
            button6.Location = new Point(268, 446);
            button6.Name = "button6";
            button6.Size = new Size(122, 23);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
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
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
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
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
