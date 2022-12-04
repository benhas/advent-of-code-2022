using System.Net.Http.Headers;

namespace AdventOfCode.Days;

public class Day2
{
    public static int GetAllScores(List<string[]> allRounds)
    {
        var totalScore = 0;
        foreach (var round in allRounds)
        {
            totalScore += ScoreRound(round[0], round[1]);
        }

        return totalScore;
    }
    public static int ScoreRound(string opponent, string me)
    {
        var meShape = GetShape(me);
        var opponentShape = GetShape(opponent);
        return meShape.Fight(opponentShape);
    }

    private static Shape? GetShape(string shape)
    {
        switch (shape)
        {
            case "X":
            case "A":
                return new Rock();
            case "Y":
            case "B":
                return new Paper();
            case "Z":
            case "C":
                return new Scissors();
        }

        return null;
    }
}

public abstract class Shape
{
    public int Weight;
    public abstract int Fight(Shape? shape);
}

public class Rock: Shape
{
    private new int Weight()
    {
        return 1;
    }

    public override int Fight(Shape? shape)
    {
        return Weight() + 
               shape.GetType().Name.ToLower() switch
        {
            "rock" => 3,
            "paper" => 0,
            "scissors" => 6,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}

public class Paper: Shape
{
    private new int Weight()
    {
        return 2;
    }

    public override int Fight(Shape? shape)
    {
        return Weight() +
               shape.GetType().Name.ToLower()
                   switch
                   {
                       "rock" => 6,
                       "paper" => 3,
                       "scissors" => 0,
                       _ => throw new ArgumentOutOfRangeException()
                   };
    }
}
public class Scissors: Shape
{
    private new int Weight()
    {
        return 3;
    }

    public override int Fight(Shape? shape)
    {
        return Weight() +
               shape.GetType().Name.ToLower() switch
               {
                   "rock" => 0,
                   "paper" => 6,
                   "scissors" => 3,
                   _ => throw new ArgumentOutOfRangeException()
               };
    }
}