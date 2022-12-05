namespace AdventOfCode.Console // Note: actual namespace depends on the project name.
{
    public class Day2
    {
        public static void Main(string[] args)
        {

            var fileLocation = "/Users/benmenesessosa/git/advent-of-code-2022/AdventOfCode.Console/Inputs/Day2.txt";
            
            var matches = File.ReadAllText(fileLocation)
                .Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            
            var allRounds = new List<string[]>();
            
            foreach (var match in matches)
            {
                allRounds.Add(match.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
            }

            var finalScore = Days.Day2.GetAllScores(allRounds);
            var strategicScore = Days.Day2.ScoreByFollowingStrategy(allRounds);
            
            System.Console.WriteLine(finalScore);
            System.Console.WriteLine(strategicScore);
        }
    }
}