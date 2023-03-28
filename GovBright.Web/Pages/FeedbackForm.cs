namespace GovBright.Web.Pages
{
    using GovBright.Models;
    using GovBright.Web.Services;
    using Microsoft.AspNetCore.Components;

    public partial class FeedbackForm : ComponentBase
    {
        private Feedback FeedBack = new Feedback();

        public string PostCodeSearch { get; set; }

        public List<string> Addresses = new List<string>();

        public bool FormSubmitedOK { get; private set; }

        [Inject]
        private IFeedbackService FeedbackService { get; set; }

        [Inject]
        private IAddressService AddressService { get; set; }

        private async Task HandleValidSubmit()
        {
            await FeedbackService.SaveFeedback(FeedBack);

            FormSubmitedOK = true;
            StateHasChanged();
        }

        private async Task FindAddress()
        {
            Addresses =  await AddressService.SearchAddress(PostCodeSearch);           
            StateHasChanged();
        }
    }
}
