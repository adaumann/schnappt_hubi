using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubi
{
    public class Field
    {
        public Field(int x, int y, FieldColor fieldColor, FieldType fieldType)
        {
            this.x = x;
            this.y = y;
            this.FieldColor = fieldColor;
            this.FieldType = fieldType;
            this.hasGivenHint = false;
        }

        public int x;
        public int y;

        public FieldType FieldType { get; set; }

        public FieldColor FieldColor { get; set; }

        public bool hasGivenHint { get; set; }
    }
}
