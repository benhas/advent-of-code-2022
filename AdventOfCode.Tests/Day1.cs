using Xunit;

namespace AdventOfCode.Tests;

public class Day1
{
    [Theory]
    [InlineData(new string[] {"1000", "2000", "3000"},6000)]
    [InlineData(new string[]{"4000"}, 4000)]
    [InlineData(new string[]{"5000","6000"}, 11000)]
    [InlineData(new string[]{"7000","8000","9000"}, 24000)]
    [InlineData(new string[]{"10000"}, 10000)]
    public void SumCalorieGroup_CalorieGroup_returnsSum(string[] calorieGroup, int expectedSum)
    {
        var actualSum = AdventOfCode.Days.Day1.SumCalorieGroup(calorieGroup.ToList());
        Assert.Equal(expectedSum, actualSum);
    }

    [Fact]
    public void SplitCalorieGroups_CalorieGroups_returnsGroups()
    {
        const string calorieGroups = "1000\n" +
                                     "2000\n" +
                                     "3000\n" +
                                     "\n" +
                                     "4000\n" +
                                     "\n" +
                                     "5000\n" +
                                     "6000\n" +
                                     "\n" +
                                     "7000\n" +
                                     "8000\n" +
                                     "9000\n" +
                                     "\n" +
                                     "10000\n";

        var expectedGroups = new List<List<string>>();
        expectedGroups.Add(new List<string> {"1000", "2000", "3000"});
        expectedGroups.Add(new List<string>{"4000"});
        expectedGroups.Add(new List<string> {"5000", "6000"});
        expectedGroups.Add(new List<string> {"7000", "8000", "9000"});
        expectedGroups.Add(new List<string>{"10000"});

        var actualGroups = Days.Day1.SplitCalorieGroups(calorieGroups);
        Assert.Equal(actualGroups, expectedGroups);
    }

    [Fact]
    public void ReturnHighestCalorieGroup_allCalorieGroups_sum()
    {
        const string calorieGroups = "1000\n" +
                                     "2000\n" +
                                     "3000\n" +
                                     "\n" +
                                     "4000\n" +
                                     "\n" +
                                     "5000\n" +
                                     "6000\n" +
                                     "\n" +
                                     "7000\n" +
                                     "8000\n" +
                                     "9000\n" +
                                     "\n" +
                                     "10000\n";

        var expectedSum = 24000;
        var actualsum = Days.Day1.WhichElfHasMoreCalories(calorieGroups);
        
        Assert.Equal(expectedSum, actualsum);

    }
    
    [Fact]
    public void ReturnSumTopThreeCalorieGroup_allCalorieGroups_sum()
    {
        const string calorieGroups = "1000\n" +
                                     "2000\n" +
                                     "3000\n" +
                                     "\n" +
                                     "4000\n" +
                                     "\n" +
                                     "5000\n" +
                                     "6000\n" +
                                     "\n" +
                                     "7000\n" +
                                     "8000\n" +
                                     "9000\n" +
                                     "\n" +
                                     "10000\n";

        var expectedSum = 45000;
        var actualsum = Days.Day1.SumTopThreeCalorieGroups(calorieGroups);
        
        Assert.Equal(expectedSum, actualsum);

    }
}