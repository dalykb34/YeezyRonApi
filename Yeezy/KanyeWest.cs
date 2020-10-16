using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace Yeezy
{
    class KanyeWest
    {
        public static void KanyeQoute()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"              ");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
        }
    }
}
