using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    public class SmartPenguin : MovingObject, IDefence
    {

        public SmartPenguin(string name, ScreenCoordinates coordinates)
            : base(name, coordinates)
        { }

        public int DefencePoints
        {
            get { throw new NotImplementedException(); }
        }
    }
}
