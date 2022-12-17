using Xunit;

namespace AdventOfCode.Tests;

public class Day6
{
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb",4,7)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz",4,5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg",4,6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg",4,10)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw",4,11)]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb",14,19)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz",14,23)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg",14,23)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg",14,29)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw",14,26)]
    [Theory]
    public void ReturnPositionOfUniqueChars(string signal, int sequenceSize, int expectedCharPos)
    {
        var actualCharPos = Days.Day6.ReturnPositionOfUniqueChars(signal, sequenceSize);
        Assert.Equal(actualCharPos, expectedCharPos);
    }
}