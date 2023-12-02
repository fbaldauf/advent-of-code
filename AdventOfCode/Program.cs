// See https://aka.ms/new-console-template for more information
using AdventOfCode._01;

Console.WriteLine("Hello, World!");

var dir = "../../../";
string[] input = File.ReadAllLines(dir + "/01/data");

var result = Challenge.Run(input);

Console.WriteLine(result.ToString());
