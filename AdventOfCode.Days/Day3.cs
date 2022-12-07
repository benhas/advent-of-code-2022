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
    
    public static List<List<string>> SplitInGroups(List<string> rucksacks, int groupSize = 3)
    {
        var groupedRucksacks = new List<List<string>>();
        
        for (var rucksackIndex = 0; rucksackIndex< rucksacks.Count; rucksackIndex+= groupSize)
        {
            var ruckSackGroup = new List<string>();
            ruckSackGroup.AddRange(rucksacks.Skip(rucksackIndex).Take(groupSize));
            groupedRucksacks.Add(ruckSackGroup);
        }
        return groupedRucksacks;
    }

    public static char GetCommonCharinGroup(List<string> groups)
    {
         var firstGroup = groups[0];
         var restOfGroups = groups.Skip(1).ToList();

         return firstGroup.ToCharArray()
             .FirstOrDefault(currentChar => restOfGroups.All(x => x.IndexOf(currentChar) != -1));
    }

    public static int GetSumOfCommonCharsInGroups(List<string> rucksacks)
    {
        var rucksackGroups = SplitInGroups(rucksacks);

        return rucksackGroups.Sum(group => GetCommonCharPriority(GetCommonCharinGroup(group)));
    }
}