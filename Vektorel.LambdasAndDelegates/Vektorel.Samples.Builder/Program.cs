using static System.Net.Mime.MediaTypeNames;

namespace Vektorel.Samples.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var mb = new MessageBuilder();
            //var msg = mb.Create(160, "Sayın");
            //var a = msg.Add("Can Perk!");
            //var b = a.Add("24/01/2026 tarihli dönem borcunuz:");
            //var c = b.Add("2400 TL'dir");

            //Console.WriteLine(msg.Content);
            //Console.WriteLine(a.Content);
            //Console.WriteLine(b.Content);
            //Console.WriteLine(c.Content);

            var finalize = false;

            var mb = new MessageBuilder();
            var msg = mb.Create(160, "Sayın")
                        .Add("Can Perk!")
                        .Add("Son yapılan kontroller sonucunda kurumumuza olan bakiye durumu 24/01/2026 tarihli dönem borcunuz:")
                        .Add("2400 TL'dir.")
                        //.Add("En kısa sürede bakiyenizi kapatmanızı rica ederiz. Ödeme yaptıysanız bu mesajı dikkate almayınız.")
                        .Finalize();

            //if (finalize)
            //{
            //    msg.Finalize();
            //}

            Console.WriteLine(msg.Content);
        }
    }

    public class MessageBuilder
    {
        public Message Create(int maxLength, string start = "")
        {
            return new Message
            {
                MaxLength = maxLength,
                Content = start
            };
        }        
    }

    public static class MessageExtensions
    {
        public static Message Add(this Message original, string text)
        {
            original.Content = $"{original.Content} {text}";
            original.CalculateLimits();
            return original;
        }

        public static Message Finalize(this Message original)
        {
            original.Content = $"{original.Content} İptal için 3340 RET yaz. B047";
            original.CalculateLimits();
            return original;
        }
    }

    // record burada olmaz, sebebi ise değiştirilemez olması
    // public record Message2(string Content, int MaxLength);

    public class Message
    {
        public string Content { get; set; }
        public int MaxLength { get; set; }
        public int Left { get; set; }

        public void CalculateLimits()
        {
            Left = MaxLength - Content.Length;
            if (Left < 0)
            {
                throw new OperationCanceledException($"Karakter limit aşımı. Limit: {MaxLength}, Aşım: {Left}");
            }
        }
    }
}

