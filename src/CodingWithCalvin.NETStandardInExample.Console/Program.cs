namespace CodingWithCalvin.NETStandardInExample.Console;

public class Program
{
    private static async Task Main(string[] args)
    {
        if (System.Console.IsInputRedirected)
        {
            List<string> fileLines = new();

            while (await System.Console.In.ReadLineAsync() is { } pipedInput)
            {
                fileLines.Add(pipedInput);
            }

            fileLines.ForEach(line => System.Console.WriteLine(line));
        }
        else
        {
            System.Console.WriteLine("Do something here with args, if you wanted to support both");
        }
    }
}