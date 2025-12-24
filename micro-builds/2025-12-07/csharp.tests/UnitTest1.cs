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
        var LogFilter

        List<string> lines = new List<string>();

        return LogFilter.ReturnMatches("[ERROR]", lines);

        asserts(lines.Contains(levelTag));
    }
}
