namespace GovBright.Web.Pages
{
    using GovBright.Models;
    using GovBright.Web.Services;
    using Microsoft.AspNetCore.Components;

    public partial class FeedbackForm : ComponentBase
    {
        private Feedback FeedBack = new Feedback();

        [Inject]
        private IFeedbackService FeedbackService { get; set; }

        private async Task HandleValidSubmit()
        {
            await FeedbackService.SaveFeedback(FeedBack);
        }
    }
}
