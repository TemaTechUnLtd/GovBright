using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace GovBright.Web.Services
{
    public class AddressClientHelper : IAddressClientHelper
    {
        public HttpClient HttpClient { get; set; }

        public async Task<List<string>> GetAddressesAsync(string requestUri)
        {
            var addresses = new List<string>();

            using (var client = this.GetHttpClient())
            {
                var response = await client.GetAsync(requestUri);
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
            }

            return addresses;
        }

        private HttpClient GetHttpClient()
        {
            if (HttpClient == null)//While mocking we set httpclient object to bypass actual result.  
            {
                var _httpClient = new HttpClient();
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return _httpClient;
            }
            return HttpClient;
        }      
    }
}
