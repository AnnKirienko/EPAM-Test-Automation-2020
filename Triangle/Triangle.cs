using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
   
        Point A;
        Point B;
        Point C;


        public Triangle(Point nA, Point nB, Point nC)
        {
            A = nA;
            B = nB;
            C = nC;
        }

        public Point GetPoint1()
        {
            return A;
        }

        public Point GetPoint2()
        {
            return B;
        }

        public Point GetPoint3()
        {
            return C;
        }

        public override string ToString()
        {

            return "Triangle " + this.GetPoint1() + ", " + this.GetPoint2() + ", " + this.GetPoint3();
        }
      
        public double[] GetSidesLengths()
        {

            double[] sideLengths = new double[3];


            sideLengths[0] = CalculateLengthLine(this.GetPoint1(), this.GetPoint2());

            sideLengths[1] = CalculateLengthLine(this.GetPoint2(), this.GetPoint3());

            sideLengths[2] = CalculateLengthLine(this.GetPoint3(), this.GetPoint1());

            return sideLengths;

        }

        public double CalculateLengthLine(Point point1, Point point2)
        {
            int x1 = point1.GetPointX();
            int y1 = point1.GetPointY();
            int x2 = point2.GetPointX();
            int y2 = point2.GetPointY();
            double lengthSide = System.Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2 ));
            return lengthSide;
        }

        public override bool Equals (object obj)
        {
            if (!(obj is Triangle))
            {
                return false;
            }
            Triangle tr2 = obj as Triangle;

            double[]array1 = this.GetSidesLengths();
            double[]array2 = tr2.GetSidesLengths();
            HashSet<int> usedIndexes = new HashSet<int>();
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++) 
                {   
                    if (!(usedIndexes.Contains(j)))
                    {
                    
                    if (System.Math.Abs(array1[i] - array2[j]) < System.Double.Epsilon)
                    {  usedIndexes.Add(j);
                       break;
                    }
                    }
                    
                }
                 
            }
            if (usedIndexes.Count == 3)
            {
                return true; 
            }
            
          return false;
        }
      } 
    }

