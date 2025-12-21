var utils = new FileTools();
var cli = new CliRunner();
cli.commandLineLogic(args, utils);

public class LogFilter
{
    public List<string> ReturnMatches(string levelTag, List<string> lines)
    {
        List<string> resultList = new List<string>();

        foreach (var line in lines)
        {
            if (line.Contains(levelTag))
            {
                resultList.Add(line);
            }
        }
        return resultList;
    }
}
