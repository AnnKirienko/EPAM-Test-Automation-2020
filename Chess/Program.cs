using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
      public static Cell GetCell()
        {
            Cell cell = null;
            while (true)
            {
                Console.WriteLine("Input your cell:");
                char column = char.Parse(Console.ReadLine());
                int row = int.Parse(Console.ReadLine());
                
                try
                {
                    cell = new Cell(char.ToUpper(column), row); 
                   
                    break;
                   
                }
                catch (MyNotCorrectedInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                  
            }
            return cell;
        }

        static void Main(string[] args)
        {
            Cell cell1 =  GetCell() ;
            Cell cell2 = GetCell();

            cell1.GetCellColour();

            cell1.CanBeInOneVerticalLine(cell2);
            cell2.CanBeInOneGorizontalLine(cell1);
            cell1.CanBeInOneDiagonalLine(cell2);




        }
    }
}
