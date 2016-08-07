using System;

namespace IExpect
{
    /// <summary>
    /// Represents errors that occur during expectation matching.
    /// </summary>
    /// <seealso cref="Exception" />
    public sealed class ExpectationFailedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpectationFailedException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        internal ExpectationFailedException(string message)
            : base(message)
        {
        }
    }
}
