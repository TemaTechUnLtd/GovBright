namespace GovBright.DAL
{
    using GovBright.Models;

    public interface IFeedbackRepository
    {
        Task SaveFeedback(Feedback feedbackRecord);
        Task<List<Feedback>> GetAllFeedback();
    }
}
