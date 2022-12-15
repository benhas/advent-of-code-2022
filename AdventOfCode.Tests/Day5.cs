using AdventOfCode.Days;
using Xunit;

namespace AdventOfCode.Tests;

public class Day5
{
    [Fact]
    public void TranslateInstructions_stringInstructions_translatedInstructions()
    {
        var textInstructions = new List<string>
        {
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2"
        };
        var expectedInstructions = new List<Instruction>()
        {
            new Instruction() {Amount = 1, From = 2, To = 1},
            new Instruction() {Amount = 3, From =1, To = 3},
            new Instruction() {Amount = 2, From = 2, To = 1},
            new Instruction() {Amount = 1, From = 1, To = 2}
        };

        var actualInstruction = Days.Day5.TranslateInstructions(textInstructions);
        
        Assert.Equivalent(actualInstruction, expectedInstructions);
    }

    [Fact]
    public void GetTopCratesOneAtATime_Containers_Instructions_TopCrates()
    {
        /*
                [D]    
            [N] [C]    
            [Z] [M] [P]
            1   2   3 
         
         */
        var containers = new List<Stack<string>>()
        {
            new Stack<string>(new[] {"Z", "N"}),
            new Stack<string>(new[] {"M", "C", "D"}),
            new Stack<string>(new[] {"P"})
        };

        var textInstructions = new List<string>
        {
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2"
        };
        
        var expectedSequence = "CMZ";
        
        var actualSequence = Days.Day5.GetArrangedCratesOneAtATime(containers, textInstructions);
        
        Assert.Equal(expectedSequence, actualSequence);
    }
    
    [Fact]
    public void GetTopCratesMultiple_Containers_Instructions_TopCrates()
    {
        /*
                [D]    
            [N] [C]    
            [Z] [M] [P]
            1   2   3 
         
         */
        var containers = new List<Stack<string>>()
        {
            new Stack<string>(new[] {"Z", "N"}),
            new Stack<string>(new[] {"M", "C", "D"}),
            new Stack<string>(new[] {"P"})
        };

        var textInstructions = new List<string>
        {
            "move 1 from 2 to 1",
            "move 3 from 1 to 3",
            "move 2 from 2 to 1",
            "move 1 from 1 to 2"
        };
        
        var expectedSequence = "MCD";
        
        var actualSequence = Days.Day5.GetArrangedCratesMultiple(containers, textInstructions);
        
        Assert.Equal(expectedSequence, actualSequence);
    }
}