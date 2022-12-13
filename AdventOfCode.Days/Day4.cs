namespace AdventOfCode.Days;

public static class Day4
{
    public static IEnumerable<IEnumerable<Assignment>> PopulateAssignments(List<string> assignmentPairs)
    {
        var populatedAssignments = new List<List<Assignment>>();
        foreach (var assignmentPair in assignmentPairs)
        {
            var assignments = assignmentPair.Split(",".ToCharArray());
            var instantiatedAssignmentPair = assignments
                .Select(assignment => assignment.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                .Select(splitAssignments =>
                    new Assignment(int.Parse(splitAssignments[0]), int.Parse(splitAssignments[1]))).ToList();
            populatedAssignments.Add(instantiatedAssignmentPair);
        }

        return populatedAssignments;
    }

    public static bool OverlappingAssignments(IEnumerable<Assignment> populatedAssignments)
    {
        var sortedAssignments = populatedAssignments.OrderBy(x => x.Length);
        var firstAssignment = sortedAssignments.Take(1).First();
        var secondAssignment = sortedAssignments.Skip(1).Take(1).First();
        return firstAssignment.LowerLimit >= secondAssignment.LowerLimit &&
              firstAssignment.UpperLimit <= secondAssignment.UpperLimit;
    }

    public static int TotalOverlappingAssignments(IEnumerable<string> assignments)
    {
        var populatedAssignments = PopulateAssignments(assignments.ToList());

        return populatedAssignments.Count(OverlappingAssignments);
    }
    
    public static bool AnyOverlappingAssignments(IEnumerable<Assignment> populatedAssignments)
    {
        var sortedAssignments = populatedAssignments.OrderBy(x => x.LowerLimit);
        var firstAssignment = sortedAssignments.Take(1).First();
        var secondAssignment = sortedAssignments.Skip(1).Take(1).First();
        
        return !(firstAssignment.UpperLimit < secondAssignment.LowerLimit);
    }

    public static int TotalAnyOverlappingAssignments(IEnumerable<string> assignments)
    {
        var populatedAssignments = PopulateAssignments(assignments.ToList());

        return populatedAssignments.Count(AnyOverlappingAssignments);
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
