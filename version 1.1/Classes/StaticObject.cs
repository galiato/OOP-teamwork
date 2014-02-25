using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public abstract class StaticObject : GameObject
    {
        public StaticObject(string name, Coords position)
            : base(name, position)
        { }
    }
}
