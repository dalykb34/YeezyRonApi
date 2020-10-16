using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Yeezy
{
    public class RonSwanson
    {
        public static void RonQoute()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine($"              ");
            Console.WriteLine($"RON: {ronQuote}");
        }
    }
}
