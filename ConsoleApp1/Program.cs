// See https://aka.ms/new-console-template for more information

// Request parameters
using Newtonsoft.Json.Linq;
using System.Web;

string apiKey = "PCW45-12345-12345-1234X";
string countryCode = "UK";
string searchTerm = "NR1 1NE";

// Prepare request and encode user-entered parameters with %xx encoding
string requestUrl = $"https://ws.postcoder.com/pcw/{apiKey}/address/{countryCode}/{HttpUtility.UrlEncode(searchTerm)}";

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
                Console.WriteLine($"{address["summaryline"]}");
            }
        }
        else
        {
            Console.WriteLine("No results");
        }
    }
    else
    {
        Console.WriteLine($"Request error: {responseContent}");
    }
}

 