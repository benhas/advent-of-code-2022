namespace AdventOfCode.Console;

public class Day4
{
    public static void Main(string[] args)
    {
        var fileLocation = "/Users/benmenesessosa/git/advent-of-code-2022/AdventOfCode.Console/Inputs/Day4.txt";
        var fileText = File.ReadAllText(fileLocation);
        var assignments = fileText.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        var overlappingAssignments = Days.Day4.TotalOverlappingAssignments(assignments.ToList());
        System.Console.WriteLine(overlappingAssignments);
    }
}