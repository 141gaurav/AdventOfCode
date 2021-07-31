using AdventOfCodeSolutions._2020.Day01;
using AdventOfCodeSolutions._2020.Day02;
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
            int[] inputday01 = File.ReadLines(@"F:\AdventOfCode\AdventOfCodeSolutions\2020\Day01\input.txt")
                .Select(nums => Convert.ToInt32(nums)).ToArray();

            SolutionDay01 solutionDay01 = new SolutionDay01();
            Console.WriteLine("Day 01 Part 01 AOC answer is :" + solutionDay01.ReturnExpenseReport(inputday01));
            Console.WriteLine("Day 01 Part 02 AOC answer is :" + solutionDay01.ReturnProductOfThreeEntries(inputday01));

            //Day 02 - Part 01 & 02
            string[] inputday02 = File.ReadLines(@"F:\AdventOfCode\AdventOfCodeSolutions\2020\Day02\input.txt")
                .Select(pwds => Convert.ToString(pwds)).ToArray();

            SolutionDay02 solutionDay02 = new SolutionDay02();
            Console.WriteLine("Day 02 Part 01 AOC answer is :" + solutionDay02.ValidPasswordCount(inputday02));
            Console.WriteLine("Day 02 Part 02 AOC number of valid password is :" + solutionDay02.ValidPasswordCountAfterChangeInPolicy(inputday02));
        }
    }
}
