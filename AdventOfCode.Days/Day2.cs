using System.Net.Http.Headers;

namespace AdventOfCode.Days;

public static class Day2
{
    public static int GetAllScores(IEnumerable<string[]> allRounds)
    {
        return allRounds.Sum(round => ScoreRound(round[0], round[1]));
    }
    
    public static int ScoreRound(string opponent, string me)
    {
        var meShape = GetShape(me);
        var opponentShape = GetShape(opponent);
        return meShape.Fight(opponentShape);
    }

    public static int ScoreByFollowingStrategy(IEnumerable<string[]> allRounds)
    {
        return allRounds.Sum(round => FollowStrategy(round[0], round[1]));
    }
    
    public static int FollowStrategy(string shape, string aspiredResult)
    {
        var thisShape = GetShape(shape);
        var thisAspiredResult = GetResult(aspiredResult);
        return thisShape.FollowStrategy(thisAspiredResult);
    }
    
    private static Shape? GetShape(string shape)
    {
        return shape switch
        {
            "X" => new Rock(),
            "A" => new Rock(),
            "Y" => new Paper(),
            "B" => new Paper(),
            "Z" => new Scissors(),
            "C" => new Scissors(),
            _ => null
        };
    }
    
    private static Result? GetResult(string result)
    {
        return result switch
        {
            "X" => new Lose(),
            "Y" => new Draw(),
            "Z" => new Win(),
            _ => null
        };
    }
}

public abstract class Result { }
public class Win : Result { }

public class Draw : Result { }
public class Lose : Result
{
}
public abstract class Shape
{
    public abstract int Fight(Shape? shape);
    public abstract int FollowStrategy(Result? result);
}

public class Rock: Shape
{
    private const int ROCK = 1;
    private const int PAPER = 2;
    private const int SCISSORS = 3;
    
    private const int LOSE = 0;
    private const int DRAW = 3;
    private const int WIN = 6;

    public override int Fight(Shape? shape)
    {
        return ROCK + 
               shape?.GetType().Name.ToLower() switch
        {
            "rock" => DRAW,
            "paper" => LOSE,
            "scissors" => WIN,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public override int FollowStrategy(Result? result)
    {
        return result?.GetType().Name.ToLower() switch
               {
                   "lose" => LOSE + SCISSORS,
                   "draw" => DRAW + ROCK,
                   "win" => WIN + PAPER,
                   _ => throw new ArgumentOutOfRangeException()
               };
    }
}

public class Paper: Shape
{
    private const int ROCK = 1;
    private const int PAPER = 2;
    private const int SCISSORS = 3;
    
    private const int LOSE = 0;
    private const int DRAW = 3;
    private const int WIN = 6;

    public override int Fight(Shape? shape)
    {
        return PAPER +
               shape?.GetType().Name.ToLower()
                   switch
                   {
                       "rock" => WIN,
                       "paper" => DRAW,
                       "scissors" => LOSE,
                       _ => throw new ArgumentOutOfRangeException()
                   };
    }
    public override int FollowStrategy(Result? result)
    {
        return result?.GetType().Name.ToLower() switch
               {
                   "lose" => LOSE + ROCK,
                   "draw" => DRAW + PAPER,
                   "win" => WIN + SCISSORS,
                   _ => throw new ArgumentOutOfRangeException()
               };
    }
}

public class Scissors: Shape
{
    private const int ROCK = 1;
    private const int PAPER = 2;
    private const int SCISSORS = 3;
    
    private const int LOSE = 0;
    private const int DRAW = 3;
    private const int WIN = 6;

    public override int Fight(Shape? shape)
    {
        return SCISSORS +
               shape?.GetType().Name.ToLower() switch
               {
                   "rock" => LOSE,
                   "paper" => WIN,
                   "scissors" => DRAW,
                   _ => throw new ArgumentOutOfRangeException()
               };
    }
    
    public override int FollowStrategy(Result? result)
    {
        
        return result?.GetType().Name.ToLower() switch
        {
            "lose" => LOSE + PAPER,
            "draw" => DRAW + SCISSORS,
            "win" => WIN + ROCK,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}