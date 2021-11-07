using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double minValue = 99999;
            double maxValue = -99999;

            try
            {
                foreach (double num in numbers)
                {
                    if (num < minValue)
                    {
                        minValue = num;
                    }
                    if (num > maxValue)
                    {
                        maxValue = num;
                    }
                }
            }
            catch
            {
                return 0;
            }
            return minValue + maxValue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            } else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            try
            {
                return numbers.Sum();
            }
            catch
            {
                return 0;
            }
        }

        public int SumEvens(int[] numbers)
        {
            int returnInt = 0;

            try
                {
                for (var i = 0;i < numbers.Length;i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        returnInt += numbers[i];
                    }
                }
            }
            catch
            {

            }

            return returnInt;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;

            try
            {
                foreach (int num in numbers)
                {
                    sum += num;
                }
            }
            catch
            {
            }
            if (sum%2 != 0)
            {
                return true;
            } else
            {
                return false;
            }
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long cnt = 0;

            for (long i = 0; i < number; i++)
            {
                if (i%2 != 0)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
