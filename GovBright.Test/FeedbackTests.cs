namespace GovBright.Test
{
    using GovBright.DAL;
    using GovBright.Models;
    using GovBright.Web.Exceptions;
    using GovBright.Web.Services;
    using Moq;

    public class FeedbackTests
    {
        [Fact]
        public async Task GetAllFeedback_ReturnsAllFeedback()
        {
            //arrange
            var feedbackSet = FeedbackRepositorySetup.SetupFeedbackCollection();

            var feedbackrepo = new Mock<IFeedbackRepository>();
            feedbackrepo.Setup(f => f.GetAllFeedback()).ReturnsAsync(feedbackSet);

            var feedbackservice = new FeedbackService(feedbackrepo.Object);

            //act
            var allfeedback = await feedbackservice.GetAllFeedback();

            //assert
            Assert.Equal(4, allfeedback.Count);
        }

        [Fact]
        public async Task AddFeedback_FeedBackAdded_TotalFeedbackCountIncreasesByOne()
        {
            //arrange
            var feedbackrepo = new Mock<IFeedbackRepository>();

            feedbackrepo.Setup(f => f.SaveFeedback(It.IsAny<Feedback>())).Returns(Task.CompletedTask);

            var feedbackservice = new FeedbackService(feedbackrepo.Object);

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
        }

        [Fact]
        public async Task AddFeedback_ThrowsError()
        {
            
            //arrange
            var feedbackrepo = new Mock<IFeedbackRepository>();

            feedbackrepo.Setup(f => f.SaveFeedback(It.IsAny<Feedback>()))
                .Throws<FeedbackException>();

            var feedbackservice = new FeedbackService(feedbackrepo.Object);

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
            Func<Task> act = () => feedbackservice.SaveFeedback(newFeedback);

            //assert
            var exception = await Assert.ThrowsAsync<FeedbackException>(act);
        }
    }
}