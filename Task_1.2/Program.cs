using System;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your decimal number and base of a new number system: ");
            int decimalNumber;
            while (!int.TryParse(Console.ReadLine(), out decimalNumber)&& decimalNumber < 0)
            {
                Console.Write("Format error! Input decimal number again: ");
            }
            
            int baseOfANewNumberSystem;
            while (!int.TryParse(Console.ReadLine(), out baseOfANewNumberSystem) && baseOfANewNumberSystem < 2 && baseOfANewNumberSystem > 20)
            {
                Console.Write("Format error! Input a base of a new number system again: ");
            }
            
            NumeralSystemConverter numberSystemConverter = new NumeralSystemConverter();

            Console.WriteLine(numberSystemConverter.Convert(decimalNumber, baseOfANewNumberSystem));
        }
    }
}
