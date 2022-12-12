namespace AdventOfCode.Days;

public static class Day4
{
    public static IEnumerable<IEnumerable<Assignment>> PopulateAssignments(List<string> assignmentPairs)
    {
        var populatedAssignments = new List<List<Assignment>>();
        foreach (var assignmentPair in assignmentPairs)
        {
            var assignments = assignmentPair.Split(",".ToCharArray());
            var instantiatedAssignmentPair = new List<Assignment>();
            foreach (var assignment in assignments)
            {
                var splitAssignments = assignment.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                instantiatedAssignmentPair.Add(
                    new Assignment(int.Parse(splitAssignments[0]), int.Parse(splitAssignments[1])));
            }
            populatedAssignments.Add(instantiatedAssignmentPair);
        }

        return populatedAssignments;
    }

    public static bool OverlappingAssignments(IEnumerable<Assignment> populatedAssignments)
    {
        var sortedAssignments = populatedAssignments.OrderBy(x => x.Length);
        var firstAssignment = sortedAssignments.Take(1).First();
        var secondAssignment = sortedAssignments.Skip(1).Take(1).First();
        return firstAssignment.Length == secondAssignment.Length
            ? firstAssignment.LowerLimit == secondAssignment.LowerLimit &&
              firstAssignment.UpperLimit == secondAssignment.UpperLimit
            : firstAssignment.LowerLimit >= secondAssignment.LowerLimit &&
              firstAssignment.UpperLimit <= secondAssignment.UpperLimit;
    }

    public static int TotalOverlappingAssignments(IEnumerable<string> assignments)
    {
        var populatedAssignments = PopulateAssignments(assignments.ToList());

        return populatedAssignments.Count(OverlappingAssignments);
    }
}
public class Assignment
{
    public int UpperLimit { get; set; }
    public int LowerLimit { get; set; }
    public int Length { get; set; }

    public Assignment(int lowerLimit, int upperLimit)
    {
        LowerLimit = lowerLimit;
        UpperLimit = upperLimit;
        Length = upperLimit - lowerLimit;
    }
}
