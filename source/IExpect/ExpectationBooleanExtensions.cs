namespace IExpect
{
    /// <summary>
    /// Matchers for boolean expectations.
    /// </summary>
    public static class ExpectationBooleanExtensions
    {
        /// <summary>
        /// Determines whether the actual value is true.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        public static void ToBeTrue(this IExpectation<bool> expectation)
        {
            ExpectationHelper.PassFail(expectation.Actual, expectation);
        }

        /// <summary>
        /// Determines whether the actual value is false.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        public static void ToBeFalse(this IExpectation<bool> expectation)
        {
            ExpectationHelper.PassFail(!expectation.Actual, expectation);
        }

        /// <summary>
        /// Determines whether the actual value is true.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        public static void ToBeTrue(this IExpectation<bool?> expectation)
        {
            var actual = expectation.Actual;

            ExpectationHelper.PassFail(actual.GetValueOrDefault(), expectation);
        }

        /// <summary>
        /// Determines whether the actual value is false.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        public static void ToBeFalse(this IExpectation<bool?> expectation)
        {
            var actual = expectation.Actual;

            ExpectationHelper.PassFail(actual.HasValue && !actual.Value, expectation);
        }

        /// <summary>
        /// Determines whether the actual value is false or null.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        public static void ToBeNullOrFalse(this IExpectation<bool?> expectation)
        {
            var actual = expectation.Actual;

            ExpectationHelper.PassFail(!actual.GetValueOrDefault(), expectation);
        }
    }
}
