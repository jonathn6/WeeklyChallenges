using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evenArray = numbers.Where(num => num % 2 == 0);
            var oddArray = numbers.Where(num => num % 2 != 0);
            return evenArray.Sum() - oddArray.Sum();

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new string[] { str1, str2, str3, str4 };
            return stringList.OrderBy(word => word.Length).FirstOrDefault().Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var passedNumbers = new int[] { number1, number2, number3, number4 };
            return passedNumbers.Min(num => num);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            return;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1==0 || sideLength2==0 || sideLength3==0)
            {
                return false;
            }
            var sideLengths = new int[] { sideLength1, sideLength2, sideLength3 };
            var sortedLengths = sideLengths.OrderBy(num=>num);
            int twoSmallerSidesSum = sortedLengths.Take(2).Sum();
            int largestSide = sortedLengths.Last();
            if (twoSmallerSidesSum > largestSide)
            {
                return true;
            } else
            {
                return false;
            }

        }

        public bool IsStringANumber(string input)
        {
           double result = 0;
           return double.TryParse(input, out result);              

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int majorityLimit = objs.Length / 2;

            if (objs.Where(element => element is null).Count() > majorityLimit)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            try
            {
                return numbers.Where(num => num % 2 == 0).Average();

            } catch
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            try
            {
                if (number<2)
                {
                    return 1;
                }
                int returnValue = number;
                for (var i=number-1;i>1;i--)
                {
                    returnValue = returnValue * i;
                }
                return returnValue;
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
}
