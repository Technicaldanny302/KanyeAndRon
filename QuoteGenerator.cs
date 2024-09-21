using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace KanyeAndRon
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();
            var KanyeURL = "https://api.kanye.rest/";

            var KanyeResponse = client.GetStringAsync(KanyeURL).Result;

            var kanyeQuote = JObject.Parse(KanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"---------------");
            Console.WriteLine($"Kanye : '{kanyeQuote}'");
            Console.WriteLine($"----------------");
            
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var RonResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(RonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"---------------");
            Console.WriteLine($"Ron : '{ronQuote}'");
            Console.WriteLine($"----------------");
        }
    }
}
