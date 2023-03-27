namespace GovBright.Web.Services
{
    using GovBright.Models;

    public interface IFeedbackService
    {
        Task SaveFeedback(Feedback feedbackRecord);
        Task<List<Feedback>> GetAllFeedback();
    }
}
