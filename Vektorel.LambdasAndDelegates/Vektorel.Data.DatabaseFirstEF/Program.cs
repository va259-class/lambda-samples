using Microsoft.EntityFrameworkCore;
using Vektorel.Data.DatabaseFirstEF.DTOs;

namespace Vektorel.Data.DatabaseFirstEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new NorthwindContext();
            var products = context.Products.Where(f => f.Stock > 0 && f.UnitPrice > 10)
                                           .OrderBy(o => o.Name)
                                           .ToList();

            var simpleProducts = context.Products.Where(p => p.Stock == 0)
                                                 .OrderBy(o => o.UnitPrice)
                                                 .Select(s => new BasicProductViewDTO
                                                 {
                                                     Name = s.Name,
                                                     Type = s.Category.CategoryName,
                                                     Price = s.UnitPrice
                                                 })
                                                 .ToList();

            foreach (var product in simpleProducts)
            {
                Console.WriteLine($"{product.Type, -15} - {product.Name, -35} - {product.Price, -10}");
            }

            Console.ReadKey();
            Console.Clear();

            var employees = context.Employees.Where(f => f.HireDate.Year >= 2023 && f.Country == "USA")
                                             .OrderByDescending(o => o.HireDate)
                                             .ToList();

            var employees2 = context.Employees.Where(f => f.HireDate.Year >= 2023 && f.Country == "USA")
                                              .Select(s => new EmployeeHireDateDTO
                                              {
                                                  FullName = $"{s.FirstName} {s.LastName}",
                                                  HireDate = s.HireDate,
                                              })
                                              .OrderByDescending(o => o.HireDate)
                                              .ToList();

            foreach (var e in employees2)
            {
                //Console.WriteLine($"{e.HireDate.ToString("dd/MM/yyyy"), -15} {e.FirstName} {e.LastName}");
                Console.WriteLine($"{e.HireDate.ToString("dd/MM/yyyy"), -15} {e.FullName}");
            }
        }
    }
}
