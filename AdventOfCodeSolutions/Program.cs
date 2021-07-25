using AdventOfCodeSolutions._2020.Day01;
using System;
using System.IO;
using System.Linq;

namespace AdventOfCodeSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Day 01 - Part 01 & 02
            int[] inputday01 = File.ReadLines(@"F:\AOC\AdventOfCode\AdventOfCodeSolutions\2020\Day01\input.txt")
                .Select(nums => Convert.ToInt32(nums)).ToArray();

            SolutionDay01 solutionDay01 = new SolutionDay01();
            Console.WriteLine("Day 01 Part 01 AOC answer is :" + solutionDay01.ReturnExpenseReport(inputday01));
            Console.WriteLine("Day 01 Part 02 AOC answer is :" + solutionDay01.ReturnProductOfThreeEntries(inputday01));
        }
    }
}
