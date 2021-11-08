using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (var i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            
            int sum = 0;
            try
            {
                foreach (var num in numbers)
                {
                    if (num%2!=0)
                    {
                        sum += num;
                    }
                }
                if (sum%2!=0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch
            { return false; }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            char[] ch = password.ToCharArray();
            int result = 0;
            char tempLetter = 'n';
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            for (var i=0;i<ch.Length;i++)
            {
                if (int.TryParse(Char.ToString(ch[i]), out result))
                {
                    hasNumber = true;
                } else
                {
                tempLetter = Char.ToUpper(ch[i]);
                    if (tempLetter==ch[i])
                    {
                        hasUpper = true;
                    }
                    tempLetter = Char.ToLower(ch[i]);
                    if (tempLetter == ch[i])
                    {
                        hasLower = true;
                    }
                }
            }

            if (hasUpper == hasLower && hasLower == hasNumber && hasNumber == true)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] tempString = val.ToCharArray();
            return tempString[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] tempString = val.ToCharArray();
            return tempString[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal result  = divisor==0 ?  0 :  dividend / divisor;
            return result;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];

        }

        public int[] GetOddsBelow100()
        {
            int[] oddsBelow100 = new int[50];
            int index = -1;

            for (var i=1;i<100;i=i+2)
            {
                oddsBelow100[++index] = i;
            }

            return oddsBelow100;

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i=0;i<words.Length;i++)
                {
                    words[i] = words[i].ToUpper();
                }
            return;
        }
    }
}
