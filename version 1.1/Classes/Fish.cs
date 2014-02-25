using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public class Fish : StaticObject
    {
        public Fish( Coords position)
            : base( position)
        {
            this.Shape = new char[,] { { '%' } };
        }
    }
}
