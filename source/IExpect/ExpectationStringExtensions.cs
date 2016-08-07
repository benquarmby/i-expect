using System.Text.RegularExpressions;

namespace IExpect
{
    /// <summary>
    /// Matchers for string expectations.
    /// </summary>
    public static class ExpectationStringExtensions
    {
        /// <summary>
        /// Determines whether the actual value starts with the expected value.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="expected">The expected value.</param>
        public static void ToStartWith(this IExpectation<string> expectation, string expected)
        {
            var pass = expectation.Actual != null && expectation.Actual.StartsWith(expected);

            ExpectationHelper.PassFail(pass, expectation, expected);
        }

        /// <summary>
        /// Determines whether the actual value ends with the expected value.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="expected">The expected value.</param>
        public static void ToEndWith(this IExpectation<string> expectation, string expected)
        {
            var pass = expectation.Actual != null && expectation.Actual.EndsWith(expected);

            ExpectationHelper.PassFail(pass, expectation, expected);
        }

        /// <summary>
        /// Determines whether the actual value contains the expected value.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="expected">The expected value.</param>
        public static void ToContain(this IExpectation<string> expectation, string expected)
        {
            var pass = expectation.Actual != null && expectation.Actual.Contains(expected);

            ExpectationHelper.PassFail(pass, expectation, expected);
        }

        /// <summary>
        /// Determines whether the actual value matches the expected regular expression pattern.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="pattern">The expected regular expression pattern.</param>
        public static void ToMatch(this IExpectation<string> expectation, string pattern)
        {
            var regex = new Regex(pattern);

            ExpectationHelper.PassFail(regex.IsMatch(expectation.Actual), expectation, pattern.ToString());
        }

        /// <summary>
        /// Determines whether the actual value matches the expected regular expression pattern with the specified options.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="pattern">The expected regular expression pattern.</param>
        /// <param name="options">The regular expression options.</param>
        public static void ToMatch(this IExpectation<string> expectation, string pattern, RegexOptions options)
        {
            var regex = new Regex(pattern, options);

            ExpectationHelper.PassFail(regex.IsMatch(expectation.Actual), expectation, pattern.ToString());
        }

        /// <summary>
        /// Determines whether the actual value matches the expected regular expression.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="pattern">The expected regular expression.</param>
        public static void ToMatch(this IExpectation<string> expectation, Regex pattern)
        {
            ExpectationHelper.PassFail(pattern.IsMatch(expectation.Actual), expectation, pattern.ToString());
        }
    }
}
