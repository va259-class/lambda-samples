namespace Vektorel.OnlyFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var svc = new ShoppingCartService();
            svc.Add("Spoon", 20, 6); // 120 -> 108
            svc.Add("Fork", 30, 3); // 90   -> 90
            svc.Add("Knife", 50, 2); // 100 -> 100

            svc.Confirm();

            svc.Confirm(total =>
            {
                if (total > 100)
                {
                    return total * 0.9M;
                }
                return total;
            });
        }
    }

    class ShoppingCartService
    {
        private readonly List<Product> products;
        public ShoppingCartService()
        {
            products = new List<Product>();
        }

        public void Add(string name, decimal price, int quantity)
        {
            products.Add(new Product { Name = name, Price = price, Quantity = quantity });
        }

        public void Confirm()
        {
            var quantity = products.Count();
            var total = products.Sum(p => p.Price * p.Quantity);

            Console.WriteLine($"Toplam {quantity} kalem ürün için ödenecek tutar : {total} TL");
        }

        public void Confirm(Func<decimal, decimal> discount)
        {
            var quantity = products.Count();
            var total = products.Sum(p => discount(p.Price * p.Quantity));
            Console.WriteLine($"Toplam {quantity} kalem ürün için ödenecek tutar : {total} TL");
        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
