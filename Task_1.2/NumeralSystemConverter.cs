using System.Collections.Generic;
using System.Text;


namespace Task_1_2
{
    public class NumeralSystemConverter
    {
        private Dictionary<int, string> numLetMapping = new Dictionary<int, string>(11)
        {
            { 10,"A"}, { 11,"B"},{12,"C" },{13, "D"},{14,"E"},{ 15,"F"},{16,"G"},{17,"H"},{ 18,"I"},{19,"J"},{20,"K"}
        };

        public string Convert(int decimalNumber, int systemBase)
        {
            

            int divisionRemainder; 
            int divisionQuotient; 

            StringBuilder resultNumber = new StringBuilder();

           
            while (true)
            {
                divisionQuotient = decimalNumber / systemBase;
                divisionRemainder = decimalNumber % systemBase;
                decimalNumber = divisionQuotient;

                resultNumber.Insert(0, divisionRemainder > 9 ? ConvertNumberToLetter(divisionRemainder, numLetMapping) : divisionRemainder.ToString());

                if (divisionQuotient < 1)
                {
                    break;
                }
            }

            return resultNumber.ToString();
        }

        private string ConvertNumberToLetter(int number, Dictionary<int, string> mapping)
        {
            return mapping[number];
        }
    }
}
