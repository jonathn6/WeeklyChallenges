using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var next_number = false;
            do
            {
                startNumber++;
                if (startNumber % n == 0)
                {
                    next_number = true;
                }
            } while (next_number == false);

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool return_value = true;
            if (numbers is null)
            {
                return false;
            }

            if (numbers.Length > 0)
            {
                for (var i = 1; i< numbers.Length;i++)
                {
                    if (numbers[i]<numbers[i-1])
                    {
                        return false;
                    }
                }
            } else { return_value = false; }
            return return_value;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers is null)
            {
                return 0;
            }
            var sumOfElements = 0;
            for (var i=0;i<numbers.Length-1;i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfElements += numbers[i+1];
                }
            }
            return sumOfElements;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words is null)
            {
                return "";
            }

            var return_string = "";

            foreach (string word in words)
            {
                if (word != " ")
                {
                    if (word.Length>0)
                    {
                        var temp_word = word.Trim();
                        if (temp_word.Length > 0)
                        {
                            return_string += temp_word + " ";
                        }
                        
                    }

                }
            }
            return_string = return_string.Trim();

            if (return_string.Length > 1)
            {
                return_string += ".";
            }
            return return_string;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var return_list = new List<double>();

            var forthCounter = 0;
            try
            {
                foreach (double element in elements)
                {
                    forthCounter++;
                    if (forthCounter == 4)
                    {
                        forthCounter = 0;
                        return_list.Add(element);
                    }
                }
            }
            catch
            {

            }
            double[] return_array = return_list.ToArray();
            return return_array;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int sumOfTwoElements = 0;
            bool return_value = false;

            for (var i = 0;i<nums.Length-1;i++)
            {
                for (var r = i+1;r<nums.Length;r++)
                {
                    sumOfTwoElements = nums[i] + nums[r];
                    if (sumOfTwoElements == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return return_value;
        }
    }
}
