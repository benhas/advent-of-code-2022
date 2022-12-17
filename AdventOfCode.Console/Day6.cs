namespace AdventOfCode.Console;

public class Day6
{
    public static void Main(string[] args)
    {
        var fileLocation = "/Users/benmenesessosa/git/advent-of-code-2022/AdventOfCode.Console/Inputs/Day6.txt";
        var fileText = File.ReadAllText(fileLocation);
        var charPos = Days.Day6.ReturnPositionOfUniqueChars(fileText, 14);
        System.Console.WriteLine(charPos);
    }
}