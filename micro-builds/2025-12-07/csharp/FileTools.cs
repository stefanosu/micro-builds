public class FileTools
{
    public List<string> ReadLogFile(string path)
    {
        string[] lines = File.ReadAllLines(path);
        List<string> files = new List<string>(lines);

        return files;
    }
}
