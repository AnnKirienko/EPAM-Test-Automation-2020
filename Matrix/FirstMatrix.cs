using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class FirstMatrix<T> 
    {
       private int size;
       
       private int elementsCount;

       T[] matrix;

        public delegate void ElementChanged(string message);
        public event ElementChanged Notification;

        public FirstMatrix(int size)
        {
            this.size = size;
            matrix = new T[size* size];
        }

        public T this[int index1, int index2]
        {
            get
            {
                return matrix[CalculateIndex(index1, index2)];
            }
             set
            {
                //Console.WriteLine(index1 + " " + index2);
                if (elementsCount > (size*size))
                { 
                    throw new ArgumentException("Matrix is full1!");
                }

                int index = CalculateIndex(index1, index2);
               // Console.WriteLine(index);
                T previousValue = matrix[index];
                if (!(Object.Equals(value, previousValue))) // если записываем тот же элемент, то ничего не делаем, если другой то вызываем ивэнт
                {
                    if (Notification != null)
                    Notification("Student was added");
                }
                matrix[index] = value;
                elementsCount++;
            }
        }

        private bool IsNullOrDefaultValue(T value)
        {
            return object.Equals(value, default(T));
        }

        public void PrintMessage(string mes)
       { Console.WriteLine("Element was changed!!!!!!!!!!!!!!!!!!"); }

        private int CalculateIndex(int index1, int index2)
        {
            
            return (index1  ) * size +  index2; 
        }

        public bool IsDiagonal()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i != j) && (!IsNullOrDefaultValue(matrix[CalculateIndex(i, j)]) ))
                    {
                        return false;
                    }
                }

            }
            return true;
        }






    }
}
