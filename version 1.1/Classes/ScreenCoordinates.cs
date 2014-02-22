using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    public class ScreenCoordinates
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public ScreenCoordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public static ScreenCoordinates operator + (ScreenCoordinates a, ScreenCoordinates b)
        {
            return new ScreenCoordinates(a.Row + b.Row, a.Col + b.Col);
        }

        public static ScreenCoordinates operator -(ScreenCoordinates a, ScreenCoordinates b)
        {
            return new ScreenCoordinates(a.Row - b.Row, a.Col - b.Col);
        }

        public override bool Equals(object obj)
        {
            ScreenCoordinates objAsScreenCoordinates = obj as ScreenCoordinates;

            return objAsScreenCoordinates.Row == this.Row && objAsScreenCoordinates.Col == this.Col;
        }

        public override int GetHashCode()
        {
            return this.Row.GetHashCode()*7 + this.Col;
        }
    }
}
