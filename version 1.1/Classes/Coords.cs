using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    public struct Coords
    {
        public Coords(int x, int y):this()
        {
            this.X = x;
            this.Y = y;
        }

        private int x;
        private int y;

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public static  Coords operator +(Coords first, Coords second){
            return new Coords(first.X+second.X,first.Y+second.Y);
        }
        public static  Coords operator -(Coords first, Coords second)
        {
            return new Coords(first.X - second.X, first.Y - second.Y);
        }
    }
}
