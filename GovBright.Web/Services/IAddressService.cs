namespace GovBright.Web.Services
{
    public interface IAddressService
    {
        Task<List<string>> SearchAddress(string searchTerm);
    }
}
