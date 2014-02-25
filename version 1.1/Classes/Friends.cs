using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public abstract class Friends : MovingObject
    {
        public Friends(Coords position, Coords direction, char[,] shape)
            : base( position, direction)
        {
            this.Shape = shape;
        }
    }
}
