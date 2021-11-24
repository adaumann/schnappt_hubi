using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubi
{
    public class Vector
    {
        private Vector(int x1, int y1, int x2, int y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }

        public static Vector CreateVector(int x1, int y1, int x2, int y2)
        {
            if (x1 < 0 || y1 < 0 || x2 < 0 || y2 < 0)
            {
                return null;
            }
            if (x1 > 3 || y1 > 3 || x2 > 3 || y2 > 3)
            {
                return null;
            }
            if (x2 - x1 != 1 && y1 == y2)
            {
                return null;
            }
            if (y2 - y1 != 1 && x1 == x2)
            {
                return null;
            }

            return new Vector(x1, y1, x2, y2);

        }

        public bool isValid { get; private set; }

        public int X1 { get; private set; }

        public int Y1 { get; private set; }

        public int X2 { get; private set; }

        public int Y2 { get; private set; }


        public WallType WallType { get; set; }
    }
}
