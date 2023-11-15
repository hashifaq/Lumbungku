using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WFA_Lumbungku
{
    internal class FoodPrice
    {
        internal struct DataFood
        {
            int item_id;
            string name;
            int price;
            string unit;
            DateTime date;
        }
        public FoodPrice()
        {

        }
        async public void getFoodPrice()
        {
            string url = "https://panelharga.badanpangan.go.id/";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var EntahElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='nama-kelas']");
            var temp = EntahElement.InnerText;

            Console.WriteLine(temp);
        }
        async public Task<string> getFoodPriceFromAPI()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://panelharga.badanpangan.go.id/api/harga-bulanan/2023/1"),
                Headers =
                {
                    { "apikey", "294543cfa1ae88aa6e2cb83213707d21b03892c7" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                // Console.WriteLine(body);

                return body; // Mengembalikan nilai string
            }
        }
    }
}

