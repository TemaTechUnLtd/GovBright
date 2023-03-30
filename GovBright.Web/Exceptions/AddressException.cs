﻿namespace GovBright.Web.Exceptions
{
    [Serializable]
    public class AddressException : Exception
    {
        public AddressException()
        { }

        public AddressException(string message)
            : base(message) { }
    }
}
