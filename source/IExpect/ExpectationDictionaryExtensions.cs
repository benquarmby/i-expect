using System.Collections;

namespace IExpect
{
    /// <summary>
    /// Matchers for dictionary expectations.
    /// </summary>
    public static class ExpectationDictionaryExtensions
    {
        /// <summary>
        /// Determines whether the dictionary contains the specified key.
        /// </summary>
        /// <param name="expectation">The expectation.</param>
        /// <param name="key">The key.</param>
        public static void ToContainKey(this IExpectation<IDictionary> expectation, object key)
        {
            ExpectationHelper.PassFail(expectation.Actual.Contains(key), expectation, key.ToString());
        }
    }
}
