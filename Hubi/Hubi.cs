using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubi
{
    public class Hubi
    {
        public Hubi(int speed)
        {
            Pos = new Point(0, 0);
            Speed = speed;
            IsAwake = false;
        }

        public Point Pos { get; set; }

        public int Speed { get; set; }

        public bool IsAwake  { get; set; }
    }
}
