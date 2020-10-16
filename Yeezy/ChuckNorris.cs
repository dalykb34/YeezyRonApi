using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Yeezy
{
    public class ChuckNorris
    {
        public static void ChuckJoke()
        {
            var client = new HttpClient();
            var chuckURL = "https://api.chucknorris.io/jokes/random";
            var chuckResponse = client.GetStringAsync(chuckURL).Result;
            var chuckQuote = JValue.Parse(chuckResponse).ToString();
            Console.WriteLine($"              ");
            Console.WriteLine($"CHUCK: {chuckQuote}");

        }
    }
}
