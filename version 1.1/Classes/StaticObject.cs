using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    public abstract class StaticObject : GameObject
    {
        public StaticObject(string name, int row, int coll)
            : base(name, row, coll)
        { }
    }
}
