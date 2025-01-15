using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Point
    {

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int x { get; set; }
        public int y { get; set; }

        public override string ToString()
        {
            return $"({x}, {y}) and the difference is {calcDifference()}";
        }

        public int calcDifference()
        {
            return Math.Abs(x - y);
        }
    }
}   
