using System;

namespace TaskSh1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
            string str = Console.ReadLine();

            // exeption if our string is empty
            if ( str.Length == 0 )
            {
                System.Environment.Exit(1);
            }

            int count = 1;
            int maxLength = 1;

            // create new variable for storage previous letter
            char previousLetter = str[0]; 

            for ( int i = 1; i < str.Length; i++ )
            {
                if ( previousLetter == str[i] )
                {
                    count++;
                }

                else
                {
                    previousLetter = str[i];
                    count = 1;
                }

                if ( maxLength < count )
                {
                    maxLength = count;
                }    
            }

            Console.Write( maxLength );
        }
    }
}
