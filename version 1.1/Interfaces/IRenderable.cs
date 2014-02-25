using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    public interface IRenderable
    {
        Coords Position { get; set; }
        char[,] Shape { get; set; }
    }
}
