namespace GovBright.Test
{
    using GovBright.Models;

    public static class FeedbackRepositorySetup
    {    
        public static List<Feedback> SetupFeedbackCollection()
        {
            var feedbackSet = new List<Feedback>();

            for (int index = 1; index < 5; index++)
            {
                feedbackSet.Add(new Feedback()
                {
                    Id = index,
                    Name = string.Format("Name{0}", index),
                    Email = string.Format("Name{0}@GovBright.com", index),
                    Address = "29 Acacia Road",
                    Brightness = index + 2,
                    CreatedDate = DateTime.Now,
                    LightingOk = index % 2 == 0 ? true : false,
                }); ;
            }

            return feedbackSet;
        }
    }
}
