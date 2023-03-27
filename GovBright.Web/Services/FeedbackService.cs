namespace GovBright.Web.Services
{
    using GovBright.DAL;
    using GovBright.Models;

    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackService(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public async Task<List<Feedback>> GetAllFeedback()
        {
            return await _feedbackRepository.GetAllFeedback();
        }

        public async Task SaveFeedback(Feedback feedbackRecord)
        {
            await _feedbackRepository.SaveFeedback(feedbackRecord);
        }
    }
}
