namespace GovBright.Web.Pages
{
    using GovBright.Models;
    using GovBright.Web.Services;
    using GovBright.Web.Shared;
    using Microsoft.AspNetCore.Components;

    public partial class ViewFeedback : ComponentBase
    {
        [Inject]
        private IFeedbackService feedbackService { get; set; }

        [CascadingParameter]
        public Error? Error { get; set; }

        private List<Feedback> FeedbackSet { get; set; } = new List<Feedback>();

        protected override async Task OnInitializedAsync()
        {
            try
            {
                FeedbackSet = await feedbackService.GetAllFeedback();
            }
            catch (System.Exception ex)
            {
                Error?.ProcessError(ex);
            }
        }
    }
}
