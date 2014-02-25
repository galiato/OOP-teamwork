using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public abstract class StaticObject : GameObject
    {
        public StaticObject( Coords position)
            : base(position)
        { }
    }
}
