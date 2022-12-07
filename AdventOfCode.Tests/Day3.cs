using Xunit;

namespace AdventOfCode.Tests;

public class Day3
{
    [InlineData("vJrwpWtwJgWrhcsFMMfFFhFp", 'p')]
    [InlineData("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", 'L')]
    [InlineData("PmmdzqPrVvPwwTWBwg", 'P')]
    [InlineData("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", 'v')]
    [InlineData("ttgJtRGJQctTZtZT", 't')]
    [InlineData("CrZsJsPPZsGzwwsLwLmpwMDw", 's')]
    [Theory]
    public void FindCommonChar_lineOfItems_commonChar(string items, char commonChar)
    {
        var expectedChar = commonChar;
        var actualChar = Days.Day3.FindCommonChar(items);
        Assert.Equal(actualChar, expectedChar);
    }

    [InlineData('p',16)]
    [InlineData('L',38)]
    [InlineData('P',42)]
    [InlineData('v',22)]
    [InlineData('t',20)]
    [InlineData('s',19)]
    [Theory]
    public void GetCommonCharPriority_commonChars_priority(char commonchar, int priority)
    {
        var expectedPriority = priority;
        var actualPriority = Days.Day3.GetCommonCharPriority(commonchar);
        Assert.Equal(expectedPriority, actualPriority);
    }

    [Fact]
    public void GetSumOfPriorities_rucksacks_prioritySum()
    {
        var rucksacks = new List<string>();
        rucksacks.Add("vJrwpWtwJgWrhcsFMMfFFhFp");
        rucksacks.Add("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL");
        rucksacks.Add("PmmdzqPrVvPwwTWBwg");
        rucksacks.Add("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn");
        rucksacks.Add("ttgJtRGJQctTZtZT");
        rucksacks.Add("CrZsJsPPZsGzwwsLwLmpwMDw");

        var expectedSum = 157;
        var actualSum = Days.Day3.GetSumOfPriorities(rucksacks);
        
        Assert.Equal(expectedSum, actualSum);

    }
}