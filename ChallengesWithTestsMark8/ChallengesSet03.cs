using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool retVal = false;

            for(int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    retVal = true;
                    break;
                }
            }

            return retVal;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            var odds = numbers.Where(num => num % 2 != 0).Sum();

            if(odds % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            bool upperCheck = false;
            bool lowerCheck = false;
            bool numberCheck = false;

            for(int i = 0; i < password.Length; i++)
            {
                for(int j = 0; j < upper.Length; j++)
                {
                    if (password[i] == upper[j])
                    {
                        upperCheck = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < password.Length; i++)
            {
                for (int j = 0; j < upper.Length; j++)
                {
                    if (password[i] == char.ToLower(upper[j]))
                    {
                        lowerCheck = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < password.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (password[i] == numbers[j])
                    {
                        numberCheck = true;
                        break;
                    }
                }
            }

            if(upperCheck == true && lowerCheck == true && numberCheck == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for(int i = 1; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    odds.Add(i);
                }
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if(words.Length > 0)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].ToUpper();
                }
            }            
        }
    }
}
