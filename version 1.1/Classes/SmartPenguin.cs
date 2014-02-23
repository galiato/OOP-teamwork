using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheSmartPenguin.Interfaces;

namespace TheSmartPenguin
{
    public class SmartPenguin : MovingObject, IDefense, IRender
    {
        public SmartPenguin(string name, Coords position, Coords direction, char[,] shape)
            : base(name, position, direction, shape)
        {
        }

        public int DefensePoints
        {
            get { return 100; }
        }

        public void Print()
        {

        }

        public void Render()
        {

        }


    }
}
