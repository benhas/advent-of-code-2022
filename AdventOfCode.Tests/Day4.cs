using AdventOfCode.Days;
using Xunit;

namespace AdventOfCode.Tests;

public class Day4
{
    [InlineData(2,4,6,8,false)]
    [InlineData(2,3,4,5,false)]
    [InlineData(5,7,7,9,false)]
    [InlineData(2,8,3,7,true)]
    [InlineData(6,6,4,6,true)]
    [InlineData(2,6,4,8,false)]
    [Theory]
    public void OverlappingAssignments_listOfAssignments_AreAssignmentsOverlapping(int firstLowerLimit, int firstUpperLimit, 
        int secondLowerLimit, int secondUpperLimit, bool expectedOverlapping)
    {
        var assigments = new List<Assignment>
        {
            new Assignment(firstLowerLimit, firstUpperLimit),
            new Assignment(secondLowerLimit, secondUpperLimit)
        };
        var actualOverlapping = Days.Day4.OverlappingAssignments(assigments);
        Assert.Equal(actualOverlapping, expectedOverlapping);
    }

    [Fact]
    public void TotalOverlappingAssignments_assignmentList_sumOverlappingAssignments()
    {
        var assignments = new List<string>
        {
            "2-4,6-8",
            "2-3,4-5",
            "5-7,7-9",
            "2-8,3-7",
            "6-6,4-6",
            "2-6,4-8"
        };
        var expectedOverlappingAssignments = 2;
        var actualOverlappingAssignments = Days.Day4.TotalOverlappingAssignments(assignments);
        Assert.Equal(actualOverlappingAssignments, expectedOverlappingAssignments);
    }
}