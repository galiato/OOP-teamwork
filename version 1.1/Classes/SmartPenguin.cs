using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using version_1._1.Interfaces;

namespace version_1._1
{
    public class SmartPenguin : MovingObject, IDefence, IRender
    {
        public StringBuilder penguinFirstRow;
        public StringBuilder penguinSecondRow;
        public StringBuilder penguinThirtRow;

        public SmartPenguin(string name, int row, int coll)
            : base(name, row, coll)
        { 
            this.penguinFirstRow = new StringBuilder();
            this.penguinSecondRow = new StringBuilder();
            this.penguinThirtRow = new StringBuilder();
        }

        public int DefencePoints
        {
            get { return 100; }
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(this.Coll, this.Row);
            Console.WriteLine(this.penguinFirstRow.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 1);
            Console.WriteLine(this.penguinSecondRow.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 2);
            Console.WriteLine(this.penguinThirtRow.ToString());
        }

        public void Render()
        {
             penguinFirstRow.Append("(0_");
            penguinSecondRow.Append(@"//\");
             penguinThirtRow.Append("V_/_");
        }
    }
}
