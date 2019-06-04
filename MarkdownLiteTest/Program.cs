using System;
using System.IO;
using System.Net.Http;

namespace MarkdownLiteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var response = client.PostAsync(
                "http://localhost:5000",
                new StreamContent(
                    new FileStream("test.md", FileMode.Open))
            ).Result;
            string markdown = response.Content.
                ReadAsStringAsync().Result;
            Console.WriteLine(markdown);
            Console.ReadKey();
        }
    }
}
