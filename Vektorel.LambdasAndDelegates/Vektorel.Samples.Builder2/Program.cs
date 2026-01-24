namespace Vektorel.Samples.Builder2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Meal
    {
        public Meal()
        {
            Spices = new List<Spice>();
        }
        /// <summary>
        /// yemeğin adı
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// tuzluluk oranı
        /// </summary>
        public SaltStatus SaltStatus { get; set; }
        /// <summary>
        /// eklenecek su (ml cinsinden)
        /// </summary>
        public short WaterLimit { get; set; }
        /// <summary>
        /// eklenecek baharatlar
        /// </summary>
        public List<Spice> Spices { get; set; }
        /// <summary>
        /// pişirme süresi
        /// </summary>
        public TimeOnly CookTime { get; set; }
        /// <summary>
        /// eklenecek ana malzemeler
        /// </summary>
        public string Ingredients { get; set; }
    }

    public enum SaltStatus
    {
        Less, //Az
        Normal, // Normal
        Salty // Tuzlu
    }

    public enum Spice
    {
        BlackPepper, //Kara Biber
        Coriender, // Kişniş
        Turmeric, //Zerdeçal
        Mint, //Nane,
        Sessame, //Susam
        Cumin, //Kimyon,
        Chili, // Pul Biber
        Cinnamon, // Tarçın
        Clove, //Karanfil
        Thyme, //Kekik
        BayLeaves, // Defne Yaprağı
    }
}
