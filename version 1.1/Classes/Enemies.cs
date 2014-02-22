using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    public abstract class Enemies : MovingObject, IAtack
    {
        public Enemies(string name, ScreenCoordinates coordinates)
            : base(name)
        { }

        public int AttackPoints
        {
            get
            {
                return 100;
            }
        }
    }
}
