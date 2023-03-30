namespace GovBright.Web.Exceptions
{
    [Serializable]
    public class FeedbackException : Exception
    {    
        public FeedbackException() 
        { }

        public FeedbackException(string message)
            : base(message) { }
    }
}
