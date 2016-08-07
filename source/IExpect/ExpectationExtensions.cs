namespace IExpect
{
    /// <summary>
    /// Matchers for expectations.
    /// </summary>
    public static class ExpectationExtensions
    {
        /// <summary>
        /// Determines whether the actual value is the same as the expected value.
        /// </summary>
        /// <typeparam name="TActual">The type of the actual value.</typeparam>
        /// <param name="expectation">The expectation.</param>
        /// <param name="expected">The expected value.</param>
        public static void ToBe<TActual>(this IExpectation<TActual> expectation, TActual expected)
        {
            var pass = expectation.Actual == null ? expected == null : expectation.Actual.Equals(expected);

            ExpectationHelper.PassFail(pass, expectation, expected);
        }
    }
}
