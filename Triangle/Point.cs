using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Point
    {
        public int x;
        public int y;
        // create construct with parametres
        public Point(int nx, int ny) 
        { 
            x = nx;
            y = ny;
        }

        public int GetPointX()
        {
            return (x);
        }

        public int GetPointY()
        {
            return (y);
        }

        public override string ToString()
        {
            return x.ToString() + " "  +  y.ToString(); 
        }

    }
}
