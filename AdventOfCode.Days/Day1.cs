using System.Text;
using StringSplitOptions = System.StringSplitOptions;

namespace AdventOfCode.Days;

public class Day1
{
    public static int SumCalorieGroup(List<string> calorieGroup)
    {
        return calorieGroup.Sum(int.Parse);
    }
    public static List<List<string>> SplitCalorieGroups(string allGroups)
    {
        var calorieGroups = new List<List<string>>();
        
        var splitGroups = allGroups.Split("\n\n".ToCharArray());
        var spaceCount = 0;
        var group = new List<string>();
        var splitGroupLength = splitGroups.Length;
        var elementNo = 0;
        
        foreach (var element in splitGroups)
        {
            elementNo++;

            if (element.Equals(string.Empty))
            {
                /*
                spaceCount++;
                if (spaceCount == 2)
                {
                    calorieGroups.Add(group);
                    spaceCount = 0;
                    group = new List<string>();
                }
            }
            else
            {
                group.Add(element);
                spaceCount = 0;
            }*/
                calorieGroups.Add(group);
                spaceCount = 0;
                group = new List<string>();
            }
            else
            {
                group.Add(element);
            }

           /* if (elementNo == splitGroupLength)
                calorieGroups.Add(group);*/
        }

        return calorieGroups;
    }

    public static int ReturnHighestCalorieGroup(List<int> calorieGroupCalories)
    {
        return calorieGroupCalories.Max();
    }
    
    public static int ReturnSumTopThreeCalorieGroup(List<int> calorieGroupCalories)
    {
        var sumTopThree = 0;
        var sortedList = calorieGroupCalories.OrderByDescending(p => p).ToList();
        for (var i = 0; i <= 2; i++)
        {
            sumTopThree += sortedList[i];
        }

        return sumTopThree;
    }
    

    public static int WhichElfHasMoreCalories(string allgroups)
    {
        var calorieGroups = SplitCalorieGroups(allgroups);
        var sumCalorieGroups = new List<int>();
        foreach (var calorieGroup in calorieGroups)
        {
            sumCalorieGroups.Add(Day1.SumCalorieGroup(calorieGroup));
        }
        return ReturnHighestCalorieGroup(sumCalorieGroups);
    }
    
    public static int SumTopThreeCalorieGroups(string allgroups)
    {
        var calorieGroups = SplitCalorieGroups(allgroups);
        var sumCalorieGroups = new List<int>();
        foreach (var calorieGroup in calorieGroups)
        {
            sumCalorieGroups.Add(Day1.SumCalorieGroup(calorieGroup));
        }
        return ReturnSumTopThreeCalorieGroup(sumCalorieGroups);
    }
}