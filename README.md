# I.Expect

An extensible, Jasmine inspired test assertion library for .NET.

## Installation

```
PM> Install-Package IExpect -pre
```

## Usage

```C#
// Import IExpect
using IExpect;
using xunit;

public class SampleTests
{
    [Fact(DisplayName = "Should end with a suffix, not with a prefix")]
    public void Sample()
    {
        var actual = "string with a suffix";

        // Pass the "actual" value to I.Expect(),
        // then chain an assertion
        I.Expect(actual).ToEndWith("suffix");

        // Negate an assertion with .Not
        I.Expect(actual).Not.ToEndWith("prefix");
    }
}
```
