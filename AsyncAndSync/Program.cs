
namespace AsyncAndSync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> urls = new List<string>()
            {
               "https://www.google.com",
               "https://www.instagram.com",
               "https://www.youtube.com",
               "https://www.tiktok.com",
               "https://www.discord.com"
            };
            MyHttpClient.GetData(urls).Wait();

        }

        
    }
}
