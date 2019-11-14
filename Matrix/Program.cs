using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            FirstMatrix<string> matrix1 = new FirstMatrix<string>(size);



            matrix1.Notification += matrix1.PrintMessage;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix1[i, j] = "123" + i + " " + j;
                    Console.WriteLine(matrix1[i, j]);
                }

            }
            Console.WriteLine(matrix1.IsDiagonal());

            FirstMatrix<int> matrix2 = new FirstMatrix<int>(size);
            matrix2.Notification += matrix2.PrintMessage;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix2[i, j] = i * j * 2;
                }

            }
         
        }
    } 
}
