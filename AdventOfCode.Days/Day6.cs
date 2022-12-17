namespace AdventOfCode.Days;

public static class Day6
{
    public static int ReturnPositionOfUniqueChars(string signal, int sequenceSize = 4)
    {
        var signalArray = signal.ToCharArray();
        var sequenceContainer = new List<char>();
        sequenceContainer.AddRange(signalArray.Take(sequenceSize-1));
        int currentChar;

        for (currentChar = sequenceSize-1; currentChar < signal.Length; currentChar++)
        {
            sequenceContainer.Add(signalArray[currentChar]);

            if (sequenceContainer.DistinctBy(x => x).Count() != sequenceSize)
                sequenceContainer = sequenceContainer.Skip(1).ToList();
            else
                break;
        }
        
        return currentChar + 1;
    }
    
}