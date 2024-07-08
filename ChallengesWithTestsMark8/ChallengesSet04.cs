using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int retVal = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    retVal += numbers[i];
                }
                else
                {
                    retVal -= numbers[i];
                }
            }

            return retVal;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = new string[] { str1, str2, str3, str4 };
            int retVal = str1.Length;

            for(int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length < retVal)
                {
                    retVal = strings[i].Length;
                }
            }

            return retVal;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] ints = new int[] { number1, number2, number3, number4 };
            int retVal = number1;

            for(int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < retVal)
                {
                    retVal = ints[i];
                }
            }

            return retVal;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 &&
                sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            bool retVal = double.TryParse(input, out double a);
            return retVal;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            for(int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCount++;
                }
            }

            if(objs.Length/2 < nullCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var retVal = numbers.Where(num => num % 2 == 0);

            if(retVal.Count() == 0)
            {
                return 0;
            }
            else
            {
                return retVal.Average();
            }
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int result = 1;

            for(int i = number; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
