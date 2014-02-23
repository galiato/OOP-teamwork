using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public class Fish : StaticObject
    {
        public Fish(string name, Coords position,char[,] shape)
            : base(name, position,shape)
        { }
    }
}
