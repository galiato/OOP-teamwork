using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public class Fish : StaticObject
    {
        public Fish(string name, Coords position)
            : base(name, position)
        {
            this.Shape = new char[,] { { '%' } };
        }
    }
}
