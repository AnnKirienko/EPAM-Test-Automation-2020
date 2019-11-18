using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
   public class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Program program = new Program();
           
            program.GetMaxNumberOfDifferentSymbolsConsecutive(inputString);
            program.GetMaxNumberOfSameNumbersConsecutive(inputString);
            program.GetMaxNumberOfSameLettersConsecutive(inputString);
        }

        public int GetMaxNumberOfDifferentSymbolsConsecutive(string s)
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

        public int GetMaxNumberOfSameNumbersConsecutive(string s)
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

       public int GetMaxNumberOfSameLettersConsecutive(string s)
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

      private bool IsEnglishAlphabetLetter(char c)
        {
            c = char.ToLower(c);
            return c >= 'a' && c <= 'z';
        }

    }
}
