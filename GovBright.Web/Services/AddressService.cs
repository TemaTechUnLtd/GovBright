namespace GovBright.Web.Services
{
    using GovBright.Web.Exceptions;
    using System.Web;

    public class AddressService : IAddressService
    {
        private const string apiKey = "PCWS8-6666J-EGJ3N-W4DBZ";
        private const string countryCode = "UK";

        private readonly IAddressClientHelper _httpClientHelper;

        public AddressService(IAddressClientHelper httpClientHelper)
        {
            _httpClientHelper = httpClientHelper;
        }

        public async Task<List<string>> SearchAddress(string searchTerm)
        {
            try
            {
                string requestUrl = $"https://ws.postcoder.com/pcw/{apiKey}/address/{countryCode}/{HttpUtility.UrlEncode(searchTerm)}";

                var addresses = await _httpClientHelper.GetAddressesAsync(requestUrl);

                return addresses;
            }
            catch (Exception ex)
            {

                throw new AddressException(ex.Message);
            }
        }
    }
}
