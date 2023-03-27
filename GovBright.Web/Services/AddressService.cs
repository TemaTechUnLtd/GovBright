namespace GovBright.Web.Services
{
    using Newtonsoft.Json.Linq;
    using System.Web;

    public class AddressService : IAddressService
    {
        private const string apiKey = "PCWS8-6666J-EGJ3N-W4DBZ";
        private const string countryCode = "UK";

        public AddressService() 
        {           
        }

        public async Task<List<string>> SearchAddress(string searchTerm)
        {
            string requestUrl = $"https://ws.postcoder.com/pcw/{apiKey}/address/{countryCode}/{HttpUtility.UrlEncode(searchTerm)}";

            var addresses = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                // Send request
                var response = await client.GetAsync(requestUrl);
                var responseContent = await response.Content.ReadAsStringAsync();

                // Process response
                if (response.IsSuccessStatusCode)
                {
                    JArray responseJson = JArray.Parse(responseContent);

                    if (responseJson.Count > 0)
                    {
                        foreach (JObject address in responseJson)
                        {
                            addresses.Add($"{address["summaryline"]}");
                        }
                    }                   
                }
                else
                {
                    Console.WriteLine($"Request error: {responseContent}");
                }
            }

            return addresses;
        }
    }
}
