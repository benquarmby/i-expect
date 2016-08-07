using System;
using System.Collections.Generic;
using System.Linq;

namespace IExpect
{
    /// <summary>
    /// Matchers for enumerable expectations.
    /// </summary>
    public static class ExpectationEnumerableExtensions
    {
        /// <summary>
        /// Determines whether the enumerable is empty.
        /// </summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="expectation">The expectation.</param>
        public static void ToBeEmpty<TItem>(this IExpectation<IEnumerable<TItem>> expectation)
        {
            ExpectationHelper.PassFail(!expectation.Actual.Any(), expectation);
        }

        /// <summary>
        /// Determines whether the enumerable contains the expected item.
        /// </summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="expectation">The expectation.</param>
        /// <param name="expected">The expected item.</param>
        public static void ToContain<TItem>(this IExpectation<IEnumerable<TItem>> expectation, TItem expected)
        {
            ExpectationHelper.PassFail(expectation.Actual.Contains(expected), expectation, expected.ToString());
        }

        /// <summary>
        /// Determines whether the enumerable contains an item that matches the specified predicate.
        /// </summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="expectation">The expectation.</param>
        /// <param name="predicate">The predicate.</param>
        public static void ToContain<TItem>(this IExpectation<IEnumerable<TItem>> expectation, Func<TItem, bool> predicate)
        {
            ExpectationHelper.PassFail(expectation.Actual.Any(predicate), expectation, predicate.ToString());
        }
    }
}
