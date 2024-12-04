using AdventOfCode2024;

//Input Data
var day1 = new Day1();
List<int> side1 = new List<int> { 3, 4, 2, 1, 3, 3 };
List<int> side2 = new List<int> { 4, 3, 5, 3, 9, 3 };

var day2 = new Day2();
int[,] reports = { { 7, 6, 4, 2, 1 }, { 1, 2, 7, 8, 9 }, { 9, 7, 6, 2, 1 },
                   { 1, 3, 2, 4, 5 }, { 8, 6, 4, 4, 1 }, { 1, 3, 6, 7, 9 } };

//Adevent Dec 1.
//Console.WriteLine(day1.SideBySideLists(side1, side2));

//Advent Dec 2.
Console.WriteLine(day2.SaveSafeReports(reports));