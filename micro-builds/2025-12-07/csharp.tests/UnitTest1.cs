using System.Collections.Generic;
using Xunit;

namespace csharp.tests;

public class UnitTest1
{
    // creates a List<string> with a mix of log lines
    // calls ReturnMatches("[ERROR]", lines)
    // asserts the returned count is what you expect
    // (You can also assert each returned line contains "[ERROR]".)

    [Fact]
    public void ReturnMatchesTest()
    {
        var logFilter = new LogFilter();

        List<string> lines = new List<string> { "[ERROR]", "[WARN]" };

        var result = logFilter.ReturnMatches("[ERROR]", lines);

        Assert.Equal(1, result.Count);
    }
}
