using System.Collections;

namespace IExpect
{
    public static class ExpectationDictionaryExtensions
    {
        public static void ToContainKey(this IExpectation<IDictionary> expectation, object key)
        {
            ExpectationHelper.PassFail(expectation.Actual.Contains(key), expectation, key.ToString());
        }
    }
}
