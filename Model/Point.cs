using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.BasicDemo.Model
{
    internal class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public int CalcDistance(Point otherPoint)
        {
            return x - otherPoint.x;
        }
    }
}
