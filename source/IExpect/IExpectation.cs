namespace IExpect
{
    /// <summary>
    /// Represents an expectation.
    /// </summary>
    /// <typeparam name="TActual">Any type.</typeparam>
    public interface IExpectation<out TActual>
    {
        /// <summary>
        /// Gets the actual value.
        /// </summary>
        /// <value>
        /// The actual value.
        /// </value>
        TActual Actual { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is positive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if positive; otherwise, <c>false</c>.
        /// </value>
        bool Positive { get; }

        /// <summary>
        /// Determines whether the actual value is null.
        /// </summary>
        void ToBeNull();

        /// <summary>
        /// Determines whether the actual value type is the same as the given type.
        /// </summary>
        /// <typeparam name="TExpected">The type to compare.</typeparam>
        void ToBeOfType<TExpected>();
    }
}
