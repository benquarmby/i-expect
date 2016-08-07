namespace IExpect
{
    /// <summary>
    /// Matchers for Int32 expectations.
    /// </summary>
    public static class ExpectationInt32Extensions
    {
        /// <summary>
        /// Determines whether the expected value is greater than the actual value.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="expected">The expected value.</param>
        public static void ToBeGreaterThan(this IExpectation<int> expectation, int expected)
        {
            ExpectationHelper.PassFail(expectation.Actual > expected, expectation, expected);
        }

        /// <summary>
        /// Determines whether the expected value is greater than or equal to the actual value.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="expected">The expected value.</param>
        public static void ToBeGreaterThanOrEqualTo(this IExpectation<int> expectation, int expected)
        {
            ExpectationHelper.PassFail(expectation.Actual >= expected, expectation, expected);
        }

        /// <summary>
        /// Determines whether the expected value is less than the actual value.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="expected">The expected value.</param>
        public static void ToBeLessThan(this IExpectation<int> expectation, int expected)
        {
            ExpectationHelper.PassFail(expectation.Actual < expected, expectation, expected);
        }


        /// <summary>
        /// Determines whether the expected value is less than or equal to the actual value.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="expected">The expected value.</param>
        public static void ToBeLessThanOrEqualTo(this IExpectation<int> expectation, int expected)
        {
            ExpectationHelper.PassFail(expectation.Actual <= expected, expectation, expected);
        }
    }
}
