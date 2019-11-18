using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // "abcdaaccdaa123111"
            // "111234511"
            // ",,\".;~%#$##$!"
            // "112wad,,zs.ca;;,qmqwd,;12312,md;qwd,12;,d;1,2"
            // " "
            // "   "
            // " ac 123   12f04"
            // "чацуа 123   ачсуацу 11 4"

            string inputString = Console.ReadLine();

            int GetMaxNumberOfDifferentSumbolsConsecutive(string s)
            {
                int count = 1;
                int maxCount = 0;

                if (String.IsNullOrEmpty(s))
                {
                    return maxCount;
                }

                char previousChar = s[0];

                foreach (char ch in s.Substring(1))
                {
                    if (ch != previousChar)
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                    previousChar = ch;
                }
                return maxCount;
            }

            int GetMaxNumberOfSameNumbersConsecutive(string s)
            {
                int count = 1;
                int maxCount = 0;

                if (String.IsNullOrEmpty(s))
                {
                    return maxCount;
                }

                char previousChar = s[0];

                foreach (char ch in s.Substring(1))
                {
                    // we do nothing if ch is not a digit
                    if (!char.IsDigit(ch))
                    {
                        previousChar = ch;
                        continue;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (ch == previousChar)
                    {
                        count++;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                    previousChar = ch;
                }
                return maxCount;

            }

            int GetMaxNumberOfSameLettersConsecutive(string s)
            {
                int count = 1;
                int maxCount = 0;

                if (String.IsNullOrEmpty(s))
                {
                    return maxCount;
                }

                char previousChar = s[0];

                foreach (char ch in s.Substring(1))
                {
                    if (!IsEnglishAlphabetLetter(ch))
                    {
                        count = 1;
                        previousChar = ch;
                        continue;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (ch == previousChar)
                    {
                        count++;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                    previousChar = ch;
                }
                return maxCount;
            }

            bool IsEnglishAlphabetLetter(char c)
            {
                c = char.ToLower(c);
                return c >= 'a' && c <= 'z';
            }

            Console.WriteLine(GetMaxNumberOfDifferentSumbolsConsecutive(inputString));
            Console.WriteLine(GetMaxNumberOfSameNumbersConsecutive(inputString));
            Console.WriteLine(GetMaxNumberOfSameLettersConsecutive(inputString));
        }
    }
}
