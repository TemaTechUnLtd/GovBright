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
                Name = "Name-5",
                Email = "Name-5@BlazorBright.com",
                Address = new Address
                {
                    FirstLine = "5 Wallaby Road",
                    SecondLine = "Thornington",
                    Town = "Diddlesbury",
                    County = "Murshire",
                    Postcode = "MM3 6DR"
                },
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