namespace GovBright.Test
{
    using GovBright.DAL;
    using GovBright.Models;

    internal class FeedbackRepositoryMock : IFeedbackRepository
    {
        private List<Feedback> FeedbackSet = new List<Feedback>();

        public FeedbackRepositoryMock()
        {
            InitializeMockRepository();
        }

        private void InitializeMockRepository()
        {
            for (int index = 1; index < 5; index++)
            {
                FeedbackSet.Add(new()
                {
                    Id = index,
                    Name = string.Format("Name{0}", index),
                    Email = string.Format("Name{0}@BlazorBright.com", index),
                    Address = GetAddress(index),
                    Brightness = index + 2,
                    CreatedDate = DateTime.Now,
                    LightingOk = index % 2 == 0 ? true : false,
                }); ;
            }
        }

        public async Task<List<Feedback>> GetAllFeedback()
        {
            return await Task.FromResult(FeedbackSet);
        }

        public async Task SaveFeedback(Feedback feedbackRecord)
        {
            await Task.Run(() =>
            {
                FeedbackSet.Add(feedbackRecord);
            });
        }

        private Address GetAddress(int index)
        {
            var address = new Address
            {
                FirstLine = string.Format("{0} Wallaby Road", index),
                SecondLine = "Thornington",
                Town = "Diddlesbury",
                County = "Murshire",
                Postcode = "MM3 6DR"
            };

            return address;
        }
    }
}
