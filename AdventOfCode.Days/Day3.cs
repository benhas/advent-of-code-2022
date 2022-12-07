namespace AdventOfCode.Days;

public class Day3
{
    public static char FindCommonChar(string items)
    {
        var items1 = items.Substring(0,items.Length/2);
        var items2 = items.Substring(items.Length/2);
        return char.Parse(items1.ToCharArray().First(x => items2.IndexOf(x) > -1).ToString());
    }

    public static int GetCommonCharPriority(char commonChar)
    {
        var upperOffset = 0;
        if (char.IsUpper(commonChar) )
            upperOffset = 26;

        return char.ToUpper(commonChar) - 64 + upperOffset;
    }
    
    public static int GetSumOfPriorities(List<string> rucksacks)
    {
        return rucksacks.Sum(item => GetCommonCharPriority(FindCommonChar(item)));
    }
}