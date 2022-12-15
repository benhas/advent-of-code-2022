namespace AdventOfCode.Console;

public class Day5
{
    public static void Main(string[] args)
    {
        var fileLocation = "/Users/benmenesessosa/git/advent-of-code-2022/AdventOfCode.Console/Inputs/Day5.txt";
        var fileText = File.ReadAllText(fileLocation);
        var instructions = fileText.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
        /*
                    [G] [W]         [Q]    
        [Z]         [Q] [M]     [J] [F]    
        [V]         [V] [S] [F] [N] [R]    
        [T]         [F] [C] [H] [F] [W] [P]
        [B] [L]     [L] [J] [C] [V] [D] [V]
        [J] [V] [F] [N] [T] [T] [C] [Z] [W]
        [G] [R] [Q] [H] [Q] [W] [Z] [G] [B]
        [R] [J] [S] [Z] [R] [S] [D] [L] [J]
         1   2   3   4   5   6   7   8   9          
        */
        var containers = new List<Stack<string>>()
        {
            new Stack<string>(new []{"R","G","J","B","T","V","Z"}),
            new Stack<string>(new []{"J","R","V","L"}),
            new Stack<string>(new []{"S","Q","F"}),
            new Stack<string>(new []{"Z","H","N","L","F","V","Q","G"}),
            new Stack<string>(new []{"R","Q","T","J","C","S","M","W"}),
            new Stack<string>(new []{"S","W","T","C","H","F"}),
            new Stack<string>(new []{"D","Z","C","V","F","N","J"}),
            new Stack<string>(new []{"L","G","Z","D","W","R","F","Q"}),
            new Stack<string>(new []{"J","B","W","V","P"})
        };
        //var sequence = Days.Day5.GetArrangedCratesOneAtATime(containers, instructions);
        var sequenceMultiple = Days.Day5.GetArrangedCratesMultiple(containers, instructions);
        //System.Console.WriteLine(sequence);
        System.Console.WriteLine(sequenceMultiple);
    }
}