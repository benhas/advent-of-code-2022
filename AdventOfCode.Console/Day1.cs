using AdventOfCode.Days;


namespace AdventOfCode.Console // Note: actual namespace depends on the project name.
{
    public class Day1
    {
        public static void Main(string[] args)
        {
            var fileLocation = "/Users/benmenesessosa/git/advent-of-code-2022/AdventOfCode.Console/Inputs/Day1.txt";
            var allCalorieGroups = File.ReadAllText(fileLocation);
            int maxCals = Days.Day1.WhichElfHasMoreCalories(allCalorieGroups);
            int topThreeSum = Days.Day1.SumTopThreeCalorieGroups(allCalorieGroups);
            System.Console.WriteLine(maxCals);
            System.Console.WriteLine(topThreeSum);
        }
    }
}
