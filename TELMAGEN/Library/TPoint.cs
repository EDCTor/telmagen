using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TELMAGEN
{
    public class TPoint
    {
        private int id = -1;
        public int x;
        public int y;
        public TColor TColor;

        public TPoint(int id, int x, int y, TColor TColor)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.TColor = TColor;
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
