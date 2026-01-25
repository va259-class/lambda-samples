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

            var categories = context.Categories
                                   .Select(s => new ComboBoxItem
                                   {
                                       Id = s.CategoryId,
                                       Label = s.CategoryName
                                   })
                                   .ToList();
            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = nameof(ComboBoxItem.Label);
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

        private void btnUSASuppliers_Click(object sender, EventArgs e)
        {
            using var context = new NorthwindContext();
            var suppliers = context.Suppliers.Where(s => s.Country == "USA")
                                             .Select(s => new SupplierListDTO(s.CompanyName, s.Country, s.City, s.Phone))
                                             .ToList();
            dgvAll.DataSource = suppliers;
        }

        private void btnProductInfo_Click(object sender, EventArgs e)
        {
            // Ürün Adý - Tipi - Tedarikçisi
            using var context = new NorthwindContext();
            var products = context.Products.Select(s => new ProductInfoListDTO(s.Name, s.Category.CategoryName, s.Supplier.CompanyName))
                                           .ToList();
            dgvAll.DataSource = products;
        }

        private void btnEmployeeSales_Click(object sender, EventArgs e)
        {
            using var context = new NorthwindContext();
            var orders = context.OrderDetails.GroupBy(g => g.Order.Employee.FirstName + " " + g.Order.Employee.LastName)
                                             .Select(s => new EmployeeSaleDTO(s.Key, 
                                                                              s.Sum(t => t.Quantity * t.UnitPrice)))
                                             .ToList();
            dgvAll.DataSource = orders;
        }

        private void btnCategorySale_Click(object sender, EventArgs e)
        {
            //1998 yýlýnda kategori bazlý satýþlar
            using var context = new NorthwindContext();
            var orders = context.OrderDetails.Where(f => f.Order.OrderDate.Year == 1998)
                                             .GroupBy(g => g.Product.Category.CategoryName)
                                             .Select(s => new CategorySaleDTO(s.Key, 
                                                                              s.Sum(t => t.UnitPrice * t.Quantity)))
                                             .ToList()
                                             .OrderByDescending(o => o.Total)
                                             .ToList();

            dgvAll.DataSource = orders;
        }
    }
}

//CQRS