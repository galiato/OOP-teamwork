using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public abstract class Friends : MovingObject
    {
        public Friends(string name,Coords position,Coords direction, char[,] shape)
            : base(name,position,direction, shape)
        { }
    }
}
