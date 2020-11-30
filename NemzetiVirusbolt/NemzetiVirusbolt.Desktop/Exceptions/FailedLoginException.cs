using System;

namespace NemzetiVirusbolt.Desktop.Exceptions
{
    public sealed class FailedLoginException : Exception
    {
        private const string ExceptionMessage = "Helytelen belépési adatok.";

        public FailedLoginException()
            : base(ExceptionMessage)
        {
        }
    }
}
