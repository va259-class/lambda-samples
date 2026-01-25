using Vektorel.EFUI.Models;

namespace Vektorel.EFUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            using var context = new NorthwindContext();
            var suppliers = context.Suppliers
                                   .Select(s => new ComboBoxItem
                                   {
                                       Id = s.Id,
                                       Label = s.CompanyName
                                   })
                                   .ToList();
            cmbSuppliers.DataSource = suppliers;
            cmbSuppliers.DisplayMember = nameof(ComboBoxItem.Label);
        }

        private void btnCrticalStock_Click(object sender, EventArgs e)
        {
            using var context = new NorthwindContext();
            var products = context.Products.Where(p => p.Stock <= 15)
                                           .Select(s => new ProductListDTO(s.Name, s.UnitPrice, s.Stock))
                                           .ToList();
            dgvAll.DataSource = products;
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            using var context = new NorthwindContext();
            var products = context.Products.Where(p => p.Category.CategoryName == "Beverages")
                                           .Select(s => new ProductListDTO(s.Name, s.UnitPrice, s.Stock))
                                           .ToList();
            dgvAll.DataSource = products;
        }
    }
}
