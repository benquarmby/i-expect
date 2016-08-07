using System;

namespace IExpect
{
    /// <summary>
    /// Matchers for delegate actions.
    /// </summary>
    public static class ExpectationActionExtensions
    {
        /// <summary>
        /// Determines whether the given delegate expectation throws an exception.
        /// </summary>
        /// <typeparam name="TException">The type of exception.</typeparam>
        /// <param name="expectation">The delegate expectation.</param>
        /// <returns>The exception.</returns>
        public static TException ToThrow<TException>(this IExpectation<Action> expectation)
            where TException : Exception
        {
            var typeOfT = typeof(TException);
            var exception = Capture(expectation.Actual);

            ExpectationHelper.PassFail(exception != null && typeOfT.IsAssignableFrom(exception.GetType()), expectation, typeOfT.FullName);

            return (TException)exception;
        }

        /// <summary>
        /// Determines whether the given delegate expectation throws an exception.
        /// </summary>
        /// <param name="expectation">The delegate expectation.</param>
        /// <returns>The exception.</returns>
        public static Exception ToThrow(this IExpectation<Action> expectation)
        {
            var exception = Capture(expectation.Actual);

            ExpectationHelper.PassFail(exception != null, expectation);

            return exception;
        }

        private static Exception Capture(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                return e;
            }

            return null;
        }
    }
}
