namespace GovBright.Web.Services
{
    using GovBright.DAL;
    using GovBright.Models;
    using GovBright.Web.Exceptions;

    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackService(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public async Task<List<Feedback>> GetAllFeedback()
        {
            try
            {
                return await _feedbackRepository.GetAllFeedback();
            }
            catch (Exception ex)
            {
                throw new FeedbackException(ex.Message);
            }
        }

        public async Task SaveFeedback(Feedback feedbackRecord)
        {
            try
            { 
                await _feedbackRepository.SaveFeedback(feedbackRecord);
            }
            catch (Exception ex)
            {
                throw new FeedbackException(ex.Message);
            }
        }
    }
}
