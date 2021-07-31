using System;
using System.Linq;

namespace AdventOfCodeSolutions._2020.Day02
{
    public class SolutionDay02
    {
        //Day 02 - Part 01
        public int ValidPasswordCount(string[] passwords)
        {
            int validPwd = 0;
            string range;
            int minRange = 0;
            int maxRange = 0;
            char charToBeSearched;
            string stringToBeSearched;
            int count = 0;

            for (int i = 0; i < passwords.Count(); i++)
            {
                range = passwords[i].Split(' ')[0];
                minRange = Convert.ToInt32(range.Split('-')[0]);
                maxRange = Convert.ToInt32(range.Split('-')[1]);

                charToBeSearched = passwords[i].Split(' ')[1].First();
                stringToBeSearched = passwords[i].Split(' ')[2];

                count = stringToBeSearched.Where(x => (x == charToBeSearched)).Count();
                if (count >= minRange && count <= maxRange)
                    validPwd = validPwd + 1;
            }
            return validPwd;
        }

        //Day 02 - Part 02
        public int ValidPasswordCountAfterChangeInPolicy(string[] passwords)
        {
            int validPwd = 0;
            string range;
            int minRange = 0;
            int maxRange = 0;
            char charToBeSearched;
            char[] stringToBeSearched;

            for (int i = 0; i < passwords.Count(); i++)
            {
                int occurrence = 0;
                range = passwords[i].Split(' ')[0];
                minRange = Convert.ToInt32(range.Split('-')[0]);
                maxRange = Convert.ToInt32(range.Split('-')[1]);

                charToBeSearched = passwords[i].Split(' ')[1].First();
                stringToBeSearched = passwords[i].Split(' ')[2].ToCharArray();

                for (int j = 0; j < stringToBeSearched.Count(); j++)
                {
                    if (charToBeSearched == stringToBeSearched[j])
                    {                        
                        if (j + 1 == minRange || j + 1 == maxRange)
                        {
                            occurrence = occurrence + 1;
                        }
                    }
                }
                if (occurrence == 1)
                {
                    validPwd = validPwd + 1;
                }
            }
            return validPwd;
        }
    }
}
