// See https://aka.ms/new-console-template for more information
using AdventOfCode._02;

Console.WriteLine("Hello, World!");

var dir = "../../../";
var filename = dir + "/02/data";
if (!File.Exists(filename))
{
    Console.WriteLine("Data not found!");
    return;
}
string[] input = File.ReadAllLines(filename);

var result = Challenge.Run(input);

Console.WriteLine(result.ToString());
