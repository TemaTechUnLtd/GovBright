namespace GovBright.Web.Pages
{
    using GovBright.Models;
    using GovBright.Web.Services;
    using GovBright.Web.Shared;
    using Microsoft.AspNetCore.Components;

    public partial class FeedbackForm : ComponentBase
    {
        private Feedback FeedBack = new Feedback();

        [CascadingParameter]
        public Error? Error { get; set; }

        public string PostCodeSearch { get; set; }

        public List<string> Addresses = new List<string>();

        public bool ShowNoResults { get; set; }

        public bool FormSubmitedOK { get; private set; }

        [Inject]
        private IFeedbackService FeedbackService { get; set; }

        [Inject]
        private IAddressService AddressService { get; set; }

        private async Task HandleValidSubmit()
        {
            try
            {
                await FeedbackService.SaveFeedback(FeedBack);

                FormSubmitedOK = true;
                StateHasChanged();
            }
            catch (System.Exception ex)
            {
                Error?.ProcessError(ex);
            }
        }

        private async Task FindAddress()
        {
            try
            {
                Addresses = await AddressService.SearchAddress(PostCodeSearch);
                ShowNoResults = !Addresses.Any();

                StateHasChanged();
            }
            catch (System.Exception ex)
            {
                Error?.ProcessError(ex);
            }
        }
    }
}
