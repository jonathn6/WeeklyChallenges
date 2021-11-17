using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            try
            {
                foreach (string singleWord in words)
                {
                    string sW = singleWord;
                    string w = word;
                    if (ignoreCase == true)
                    {
                        sW = sW.ToLower();
                        w = w.ToLower();
                    }
                    if (sW == w)
                    {
                        return true;
                    }
                }
            }
            catch { }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            int counter = 0;

            try
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        counter++;
                        if (counter > 2)
                        {
                            return false;
                        }
                    }
                }
            }
            catch { }
            if (counter == 2)
            {
                return true;
            } else
            {
                return false;
            }

        }

        public int IndexOfLastUniqueLetter(string str)
        {

            if (str == "")
            {
                return -1;
            }

            char[] arr = str.ToCharArray();

            if (str.Length > 1)
            {
                bool differentLetters = false;
                for (var i=0;i<str.Length;i++)
                {
                    if (arr[0] != arr[i])
                    {
                        differentLetters = true;
                    }
                }
                if (differentLetters == false)
                {
                    return -1;
                }
            }

            var letterOccurs = 0;

            for (var i = str.Length-1;i>=0; i--)
            {
                letterOccurs = 1;
                for ( var r = str.Length-1;r>=0;r--)
                {
                    if (r != i)
                    {
                        if (arr[i] == arr[r])
                        {
                            letterOccurs++;
                        }
                    }
                }
                if (letterOccurs == 1)
                {
                    return i;
                }
            }

            return 0;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int returnNumberCount = 0;

            for (var i=0; i<=numbers.Length-1;i++)
            {
                var currentNumber = numbers[i];
                var currentCount = 0;
                for (var r=0; r<=numbers.Length-1;r++)
                {
                    {
                        if (currentNumber == numbers[r])
                        {
                            currentCount++;
                            if (currentCount > returnNumberCount)
                            {
                                returnNumberCount = currentCount;
                            }
                        } else
                        {
                            currentCount = 0;
                        }
                    }
                }
            }

            return returnNumberCount;


        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthList = new List<double>();
            if (elements is null)
            {
                return nthList.ToArray();
            }
            var loopControl = 0;

            for (var i=0; i<elements.Count;i++)
            {
                loopControl++;
                if (loopControl == n)
                {
                    nthList.Add(elements[i]);
                    loopControl = 0;
                }
            }
            return nthList.ToArray();
        }
    }
}
