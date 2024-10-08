using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;


namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote();

            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote();

            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote();

            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote(); 

            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote();            
        }
    }
}
