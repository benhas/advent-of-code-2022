// See https://aka.ms/new-console-template for more information

using AdventOfCode.Days;

var fileLocation = "/Users/benmenesessosa/git/advent-of-code-2022/AdventOfCode.Console/Inputs/Day1.txt";
var allCalorieGroups = File.ReadAllText(fileLocation);
int maxCals = Day1.WhichElfHasMoreCalories(allCalorieGroups);
int topThreeSum = Day1.SumTopThreeCalorieGroups(allCalorieGroups);
Console.WriteLine(maxCals);
Console.WriteLine(topThreeSum);
