using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheSmartPenguin.Interfaces;

namespace TheSmartPenguin
{
    public class SmartPenguin : MovingObject, IDefense
    {
        public SmartPenguin(string name, Coords position, Coords direction)
            : base(name, position, direction)
        {
            this.Shape = this.StaticShape;
        }
        public override char[,] StaticShape
        {
            get
            {
                return new[,] { 
            {' ',' ',' ',' ','_',' ',' ',' ',' ',' '},
            {' ',' ','.','\'',' ','\'','.',' ',' ',' '},
            {' ',' ','|','\'','V','\'','|',' ',' ',' '},
            {' ',' ','/','.','-','.','\\',' ',' ',' '},
            {' ',' ','/','/',' ',' ','\\','\\',' ',' '},
            {'.','\'',',','|',' ',' ','|',',','\'','.'},
            {'|','/','|','|',' ',' ','|','|','\\','|'},
            {' ',' ','\\','\\','_','_','/','/',' ',' '},
            {' ',' ','/',' ','\\','/',' ','\\',' ',' '},
            {' ',' ','\'','`','\'','\'','`','\'',' ',' '}
            };
            }
        }
        public int DefensePoints
        {
            get { return 100; }
        }

        public void Print()
        {

        }


    }
}
