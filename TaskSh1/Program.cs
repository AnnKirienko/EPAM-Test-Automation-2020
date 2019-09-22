using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSh1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
           
           // String s = new String(new char[] { });
            String s = Console.ReadLine();
            if (s.Length == 0)
                System.Environment.Exit(1);
            char[] array = s.ToCharArray();
            int count = 1;
            int maxLen = 1;
            char oneLetter = array[0];
            for (int i = 1; i < s.Length; i++)
            {
                if
                    (oneLetter == array[i])
                    count++;

                else
               {
                    if
                       (maxLen < count)
                        maxLen = count;
                    count = 1;
                    oneLetter = array[i];

                }               
            }
            Console.Write(maxLen);
            Console.ReadKey();
        }
    }
}
