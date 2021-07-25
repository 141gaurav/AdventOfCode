using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeSolutions._2020.Day01
{
    public class SolutionDay01
    {
        public int ReturnExpenseReport(int[] input,int expenseSum = 2020)
        {
            int expense = 0;
            int totalExp = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                expense = expenseSum - input[i];

                for (int k = 0; k < input.Count(); k++)
                {
                    if (expense == input[k])
                        totalExp = expense * input[i];
                }
            }
            return totalExp;
        }

        public int ReturnProductOfThreeEntries(int[] input, int expenseSum = 2020)
        {
            int totalExp = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                for (int j = i + 1; j < input.Count(); j++)
                {
                    if (input[i] + input[j] < expenseSum)
                    {
                        for (int k = i + 2; k < input.Count(); k++)
                        {
                            int sumThreeNumbers = input[i] + input[j] + input[k];
                            if (sumThreeNumbers==expenseSum)
                            {
                                totalExp = input[i] * input[j] * input[k];
                            }
                        }
                    }
                }
            }
            return totalExp;
        }
    }
}
