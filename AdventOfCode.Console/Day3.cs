namespace AdventOfCode.Console;

public class Day3
{
    public static void Main(string[] args)
    {
        var fileLocation = "/Users/benmenesessosa/git/advent-of-code-2022/AdventOfCode.Console/Inputs/Day3.txt";
        var fileText = File.ReadAllText(fileLocation);
        var rucksacks = fileText.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        var sumOfPriories = Days.Day3.GetSumOfPriorities(rucksacks);
        var sumOfCommonCharsInGroups = Days.Day3.GetSumOfCommonCharsInGroups(rucksacks);
        System.Console.WriteLine(sumOfPriories);
        System.Console.WriteLine(sumOfCommonCharsInGroups);
    }
}