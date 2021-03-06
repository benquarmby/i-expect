﻿using System.Diagnostics;
using System.Text;

namespace IExpect
{
    /// <summary>
    /// Helper class for handling expectation failures.
    /// </summary>
    public static class ExpectationHelper
    {
        /// <summary>
        /// Determines whether the expectation passed or failed.
        /// </summary>
        /// <typeparam name="TActual">The type of the actual value.</typeparam>
        /// <param name="pass">If set to <c>true</c> passes the expectation.</param>
        /// <param name="expectation">The expectation.</param>
        /// <param name="args">The arguments.</param>
        public static void PassFail<TActual>(bool pass, IExpectation<TActual> expectation, params object[] args)
        {
            if (pass != expectation.Positive)
            {
                var methodName = new StackTrace().GetFrame(1).GetMethod().Name;
                var english = GetEnglishyPredicate(methodName, expectation, args);

                throw new ExpectationFailedException(english);
            }
        }

        private static string GetEnglishyPredicate<T>(string methodName, IExpectation<T> expectation, params object[] args)
        {
            var first = true;
            var builder = new StringBuilder()
                .Append("Expected '")
                .Append(expectation.Actual)
                .Append("' ");

            if (!expectation.Positive)
            {
                builder.Append("not ");
            }

            foreach (var item in methodName)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    if (char.IsUpper(item))
                    {
                        builder.Append(' ');
                    }
                }

                builder.Append(char.ToLower(item));
            }

            if (args != null)
            {
                first = true;

                foreach (var item in args)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        builder.Append(',');
                    }

                    builder
                        .Append(" '")
                        .Append(item)
                        .Append('\'');
                }
            }

            builder.Append('.');

            return builder.ToString();
        }
    }
}
