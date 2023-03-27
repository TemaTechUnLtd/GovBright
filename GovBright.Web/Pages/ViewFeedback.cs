namespace GovBright.Web.Pages
{
    using GovBright.Models;
    using GovBright.Web.Services;
    using Microsoft.AspNetCore.Components;

    public partial class ViewFeedback : ComponentBase
    {
        [Inject]
        private IFeedbackService feedbackService { get; set; }

        private List<Feedback> FeedbackSet { get; set; } = new List<Feedback>();

        protected override async Task OnInitializedAsync()
        {
            FeedbackSet = await feedbackService.GetAllFeedback();
        }
    }
}
