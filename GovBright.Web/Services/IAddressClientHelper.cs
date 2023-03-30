namespace GovBright.Web.Services
{
    public interface IAddressClientHelper
    {
        Task<List<string>> GetAddressesAsync(string requestUri);
    }
}
