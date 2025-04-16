using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndSync
{
    public class MyHttpClient
    {
        public static async Task GetData(List<string> urls)
        {
            MyHttpClient client = new MyHttpClient();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var url in urls)
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"request send: {url}");
                    }
                    else
                    {
                        Console.WriteLine($"failed: {url} - Status: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error with {url}: {ex.Message}");
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Total time: {stopwatch.Elapsed.TotalSeconds} seconds");
        }

        private async Task<HttpResponseMessage> GetAsync(string url)
        {
            throw new NotImplementedException();
        }
    }
}

