using System.Runtime.CompilerServices;
using Xunit;

namespace AdventOfCode.Tests;

public class Day2
{
    [Theory]
    [InlineData("A", "Y", 8)]
    [InlineData("B", "X", 1)]
    [InlineData("C", "Z", 6)]
    public void ScoreFight_shapes_fightScore(string opponent, string me, int expectedScore)
    {
        var actualScore = Days.Day2.ScoreRound(opponent, me);
        Assert.Equal(actualScore, expectedScore);
    }

    [Fact]
    public void GetTotalScore_rounds_totalScore()
    {
        var rounds = new List<string[]>
        {
            new string[] {"A", "Y"},
            new string[] {"B", "X"},
            new string[]{"C","Z"}
        };
        const int expectedSum = 15;
        var actualSum = Days.Day2.GetAllScores(rounds);
        Assert.Equal(expectedSum, actualSum);
    }
}