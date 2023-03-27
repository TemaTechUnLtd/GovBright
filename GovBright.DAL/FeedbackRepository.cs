namespace GovBright.DAL
{
    using GovBright.Models;
    using Microsoft.EntityFrameworkCore;

    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly DataContext _context;

        public FeedbackRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Feedback>> GetAllFeedback()
        {
            var feedbacks = new List<Feedback>();

            using (var context = _context)
            {
                feedbacks = await _context.FeedbackSet.ToListAsync();
            }

            return feedbacks;
        }

        public async Task SaveFeedback(Feedback feedbackRecord)
        {
            feedbackRecord.CreatedDate = DateTime.UtcNow;

            using (var context = _context)
            {
                context.FeedbackSet.Add(feedbackRecord);

                context.SaveChanges();
            }
        }
    }
}
