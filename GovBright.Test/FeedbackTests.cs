namespace GovBright.Test
{
    using GovBright.DAL;
    using GovBright.Models;
    using GovBright.Web.Services;

    public class FeedbackTests
    {
        [Fact]
        public async Task GetAllFeedback_ReturnsAllFeedback()
        {
            //arrange
            IFeedbackRepository feedbackrepo = new FeedbackRepositoryMock();
            var feedbackservice = new FeedbackService(feedbackrepo);

            //act
            var allfeedback = await feedbackservice.GetAllFeedback();

            //assert
            Assert.Equal(4, allfeedback.Count);
        }

        [Fact]
        public async Task AddFeedback_FeedBackAdded_TotalFeedbackCountIncreasesByOne()
        {
            //arrange
            IFeedbackRepository feedbackrepo = new FeedbackRepositoryMock();
            var feedbackservice = new FeedbackService(feedbackrepo);

            var newFeedback = new Feedback
            {
                Id = 5,
                Name = "Name5",
                Email = "Name5@GovBright.com",
                Address = "29 Acacia Road",
                Brightness = 7,
                CreatedDate = DateTime.Now,
                LightingOk = false
            };

            //act
            await feedbackservice.SaveFeedback(newFeedback);
            var allfeedback = await feedbackservice.GetAllFeedback();

            //assert
            Assert.Equal(5, allfeedback.Count);
        }
    }
}