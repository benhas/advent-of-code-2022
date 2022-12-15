using System.Text;

namespace AdventOfCode.Days;

public class Day5
{
    private delegate void ExecMove(IEnumerable<Stack<string>> containers, Instruction instruction);
    
    private static void ExecuteMoveMultiple(IEnumerable<Stack<string>> containers, Instruction instruction)
    {
        var intermediateStack = new Stack<string>();
        for (var movement = 0; movement < instruction.Amount; movement++)
        {
            var from = containers.ToArray()[instruction.From - 1];
            var crate = from.Pop();
            intermediateStack.Push(crate);
        }

        for (var movement = 0; movement < instruction.Amount; movement++)
        {
            var to = containers.ToArray()[instruction.To - 1];
            var crate = intermediateStack.Pop();
            to.Push(crate);
        }
    }
    
    public static string GetArrangedCratesMultiple(List<Stack<string>> containers, List<string> instructions)
    {
        ExecMove execMove = ExecuteMoveMultiple;
        return GetArrangedCrates(containers, instructions, execMove);
    }
    
    private static string GetArrangedCrates(List<Stack<string>> containers, List<string> instructions, ExecMove execMove)
    {
        var translatedInstructions = TranslateInstructions(instructions);
        ExecuteMoves(containers, translatedInstructions, execMove);
        return GetTopCrates(containers);
    }

    public static IEnumerable<Instruction> TranslateInstructions(IEnumerable<string> instructions)
    {
        return instructions
            .Select(instruction => instruction.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)).Select(
                splitInstruction => new Instruction()
                {
                    Amount = int.Parse(splitInstruction[1]), From = int.Parse(splitInstruction[3]),
                    To = int.Parse(splitInstruction[5])
                }).ToList();
    }
    
    private static void ExecuteMoves(IEnumerable<Stack<string>> containers, IEnumerable<Instruction> instructions, ExecMove execMove)
    {
        foreach (var instruction in instructions)
        {
            execMove(containers, instruction);
        }
    }
    
    private static string GetTopCrates(List<Stack<string>> containers)
    {
        var sequence = new StringBuilder();
        foreach (var container in containers)
        {
            sequence.Append(container.Pop());
        }

        return sequence.ToString();
    }
    
    public static string GetArrangedCratesOneAtATime(List<Stack<string>> containers, List<string> instructions)
    {
        ExecMove execMove = ExecuteMoveOneCrateAtATime;
        return GetArrangedCrates(containers, instructions, execMove);
    }

    private static void ExecuteMoveOneCrateAtATime(IEnumerable<Stack<string>> containers, Instruction instruction)
    {
        for(var movement = 0; movement < instruction.Amount; movement++)
        {
            var from = containers.ToArray()[instruction.From - 1];
            var to = containers.ToArray()[instruction.To-1];
            var crate = from.Pop();
            to.Push(crate);
        }
    }
}

public class Instruction
{
    public int Amount { get; init; }
    public int From { get; init; }
    public int To { get; init; }
}