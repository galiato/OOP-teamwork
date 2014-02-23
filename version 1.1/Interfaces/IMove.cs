using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public interface IMovable
    {
         Coords Direction { get; set; }
    }
}
