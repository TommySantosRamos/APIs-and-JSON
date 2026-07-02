using System.Net.Http;
using Newtonsoft.Json.Linq;
namespace APIs_and_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse)["quote"].ToString();
            Console.WriteLine(kanyeQuote);

        }
    }
}
