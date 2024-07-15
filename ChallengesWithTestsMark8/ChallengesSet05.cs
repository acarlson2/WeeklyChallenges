using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(Business b in businesses)
            {
                if(b.TotalRevenue == 0)
                {
                    b.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool retVal = true;

            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] <= numbers[i])
                {
                    continue;
                }
                else
                {
                    retVal = false;
                    break;
                }
            }

            return retVal;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if(numbers == null || numbers.Length == 0)
            {
                return sum;
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && i != numbers.Length-1)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {            
            string retVal = "";
            if(words == null || words.Length == 0)
            {
                return retVal;
            }

            string extra = "";

            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim().Length > 0)
                {
                    extra += words[i].Trim() + " ";
                }
            }

            if(extra.Length == 0)
            {
                return retVal;
            }

            return extra.Trim() + ".";

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            IEnumerable<double> fours = elements.Where(four => four % 4 == 0);

            return fours.ToArray<double>();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool retVal = false;

            if(nums == null || nums.Length < 2)
            {
                return retVal;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber)
                    {
                        retVal = true;
                        break;
                    }
                }
            }

            return retVal;
        }
    }
}
