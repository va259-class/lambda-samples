using Vektorel.Samples.Builder2.Enums;

namespace Vektorel.Samples.Builder2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var musakka = new Meal().SetName("Patlıcan Musakka")
                                    .AddMainContent("2 patlıcan")
                                    .AddMainContent("100 gr kıyma")
                                    .AddMainContent("4 parça çarliston biber")
                                    .AddMainContent("Salça")
                                    .DefineWater(200)
                                    .MakeSalty()
                                    .AddSpice(Spice.BlackPepper)
                                    .AddSpice(Spice.Chili)
                                    .AddSpice(Spice.Thyme)
                                    .AddSpice(Spice.Cumin)
                                    .SetCookTime(45)
                                    .GiveReceipt();

            Console.WriteLine(musakka);
        }
    }
}
