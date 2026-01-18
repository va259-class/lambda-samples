namespace Vektorel.ActionAndFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pg = new PlayGround();
            pg.Try();
            Console.WriteLine();
            pg.ConfigureTv();

            //Console.WriteLine();
            //pg.ConfigureTv(new TelevisionConfiguration
            //{
                
            //});

            Console.WriteLine();
            pg.ConfigureTv(c =>
            {
                c.Frequency = 55;
                c.GreenRatio += 10;
            });
        }

        static void Configure(TelevisionConfiguration configuration)
        {
            configuration.Frequency = 55;
            configuration.RedRatio = 180;
        }
    }

    class PlayGround
    {
        public void Try()
        {
            Action hello = () =>
            {
                Console.WriteLine("Merhaba ben iç gövdeden geliyorum");
            };
            Action<string> helloByName = (name) =>
            {
                Console.WriteLine($"Merhaba {name}! Ben iç gövdeden geliyorum");
            };

            hello.Invoke();
            hello();

            helloByName.Invoke("Can");
            helloByName("Can");
        }

        // Varsayılan konfigürasyon ile ilerle
        public void ConfigureTv()
        {
            var privateConfiguration = GetDefaultTvConfiguration();
            ConfigureByTvConfiguration(privateConfiguration);
        }

        // Konfigürasyonu olduğu gibi dışarıdan tanımla. Çok tercih edilen bir yöntem olmasa gerek
        public void ConfigureTv(TelevisionConfiguration configuration)
        {
            //uzun kodlar

            ConfigureByTvConfiguration(configuration);
        }

        // Varolan konfigürasyonu özelleştir
        public void ConfigureTv(Action<TelevisionConfiguration> configure)
        {
            //uzun kodlar
            var privateConfiguration = GetDefaultTvConfiguration();

            configure(privateConfiguration);

            ConfigureByTvConfiguration(privateConfiguration);
        }

        private static TelevisionConfiguration GetDefaultTvConfiguration()
        {
            return new TelevisionConfiguration
            {
                Frequency = 50,
                Scheme = "Color",
                RedRatio = 100,
                GreenRatio = 80,
                BlueRatio = 120
            };
        }

        private void ConfigureByTvConfiguration(TelevisionConfiguration configuration)
        {
            //Sinyal ayarlama kodları yazıldı varsayımı
            Console.WriteLine("TV ayarlaması istenen ayarlarla yapıldı.");
            Console.WriteLine("Frekans : {0}", configuration.Frequency);
            Console.WriteLine("RGB Oranı : {0}-{1}-{2}", configuration.RedRatio, configuration.GreenRatio, configuration.BlueRatio);
            Console.WriteLine("Format : {0}", configuration.Scheme);
        }
    }

    class TelevisionConfiguration
    {
        public int Frequency { get; set; }
        public string Scheme { get; set; }
        public int RedRatio { get; set; }
        public int GreenRatio { get; set; }
        public int BlueRatio { get; set; }
    }
}
