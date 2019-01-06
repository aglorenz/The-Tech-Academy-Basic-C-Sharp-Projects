using System;

namespace AdvancedExceptionHandling
{
    public class NegativeOrZeroException : Exception
    {
        public NegativeOrZeroException()
            : base() { }
        public NegativeOrZeroException(string message)
            : base(message) { }
    }
}
