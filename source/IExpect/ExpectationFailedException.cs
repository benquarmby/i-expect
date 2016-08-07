using System;

namespace IExpect
{
    public sealed class ExpectationFailedException : Exception
    {
        internal ExpectationFailedException(string message)
            : base(message)
        {
        }
    }
}
