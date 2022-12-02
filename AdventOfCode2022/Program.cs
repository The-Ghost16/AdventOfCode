// See https://aka.ms/new-console-template for more information

using AdventOfCode2022;

Console.WriteLine("Hello, Advent of Code 2022!");

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Running day 1!");
var day1 = new Day1();
await day1.Execute();
Console.WriteLine("Finished day 1!");
Console.WriteLine("---------------------------------------------------------");


Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Running day 2!");
var day2 = new Day2();
await day2.Execute();
Console.WriteLine("Finished day 2!");
Console.WriteLine("---------------------------------------------------------");