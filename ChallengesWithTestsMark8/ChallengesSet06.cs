using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool retVal = false;
            
            if(words == null)
            {
                return retVal;
            }

            if(ignoreCase)
            {
                word = word.ToLower();
                foreach(var v in words)
                {
                    if(v == null)
                    {
                        continue;
                    }
                    else
                    {
                        string compare = v.ToLower();
                        if (compare == word)
                        {
                            retVal = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach(var v in words)
                {
                    if(v == null)
                    {
                        continue;
                    }
                    else
                    {
                        if (word == v)
                        {
                            retVal = true;
                            break;
                        }
                    }
                }
            }

            return retVal;
        }

        public bool IsPrimeNumber(int num)
        {
            int count = 0;
            if(num == 0)
            {
                return false;
            }
            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    count++;
                }
            }

            if(count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(str.Distinct().Reverse().Where(x => str.Where(y => y.Equals(x)).Count() == 1).FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> retVal = new List<double>();

            if (elements == null || elements.Count == 0 || n > elements.Count || n < 0)
            {
                return new double[] { };
            }

            for(int i = n-1; i < elements.Count; i+=n)
            {
                retVal.Add(elements[i]);
            }

            return retVal.ToArray();
        }
    }
}
