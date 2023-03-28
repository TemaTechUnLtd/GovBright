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
            var allFeedbacks = new List<Feedback>();

            
                allFeedbacks = await _context.FeedbackSet.ToListAsync();
            

            return allFeedbacks;
        }

        public async Task SaveFeedback(Feedback feedbackRecord)
        {
            feedbackRecord.CreatedDate = DateTime.UtcNow;

          
                _context.FeedbackSet.Add(feedbackRecord);

                _context.SaveChanges();
          
        }
    }
}
