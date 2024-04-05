using System;


namespace TryCatchAssignment
{
    public class AgeException : Exception
    {
        public AgeException()
            : base() { }
        public AgeException(string message)
            : base(message) { }
    }
}
