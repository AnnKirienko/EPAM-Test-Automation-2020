using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[15];
            points[0] = new Point(5, 4);
            points[1] = new Point(10, 8);
            points[2] = new Point(1, 3);
            points[3] = new Point(2, 8);
            points[4] = new Point(12, 45);
            points[5] = new Point(14, 3);
            points[6] = new Point(8, 5);
            points[7] = new Point(1, 3);
            points[8] = new Point(2, 7);
            points[9] = new Point(3, 9);
            points[10] = new Point(10, 13);
            points[11] = new Point(11, 23);
            points[12] = new Point(10, 8);
            points[13] = new Point(5, 4);
            points[14] = new Point(1, 3);

            foreach (Point point in points)
            Console.WriteLine ( point );

            Triangle[] triangles = new Triangle[5];
            triangles[0] = new Triangle(points [0], points [1], points[2]);
            triangles[1] = new Triangle(points [3], points [4], points[5]);
            triangles[2] = new Triangle(points [6], points [7], points[8]);
            triangles[3] = new Triangle(points [9], points [10], points[11]);
            triangles[4] = new Triangle(points [12], points [13], points[14]);

            for (int i = 0; i < triangles.Length - 1; i++ )
            {
                for (int j = i+1; j < triangles.Length; j++ )
                {
                    triangles[i].Equals(triangles[j]);
                    Console.WriteLine("Triangle{0} {1} and Triangle{2} {3}  are equals?   {4}", i, triangles[i], j, triangles[j], triangles[i].Equals(triangles[j]));
                
                }
                    
            }
                

           

        }
    }
}



