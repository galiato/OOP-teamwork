using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using version_1._1.Interfaces;

namespace version_1._1
{
    public class SmartPenguin : MovingObject, IDefence, IRender
    {
        public StringBuilder penguin1Row;
        public StringBuilder penguin2Row;
        public StringBuilder penguin3Row;
        public StringBuilder penguin4Row;
        public StringBuilder penguin5Row;
        public StringBuilder penguin6Row;
        public StringBuilder penguin7Row;
        public StringBuilder penguin8Row;
        public StringBuilder penguin9Row;
        public StringBuilder penguin10Row;
        public StringBuilder penguin11Row;

        public SmartPenguin(string name, int row, int coll)
            : base(name, row, coll)
        { 
            this.penguin1Row = new StringBuilder();
            this.penguin2Row = new StringBuilder();
            this.penguin3Row = new StringBuilder();
            this.penguin4Row = new StringBuilder();
            this.penguin5Row = new StringBuilder();
            this.penguin6Row = new StringBuilder();
            this.penguin7Row = new StringBuilder();
            this.penguin8Row = new StringBuilder();
            this.penguin9Row = new StringBuilder();
            this.penguin10Row = new StringBuilder();
            this.penguin11Row = new StringBuilder();
            
        }

        public int DefencePoints
        {
            get { return 100; }
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.SetCursorPosition(this.Coll, this.Row);
            Console.WriteLine(this.penguin1Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 1);
            Console.WriteLine(this.penguin2Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 2);
            Console.WriteLine(this.penguin3Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 3);
            Console.WriteLine(this.penguin4Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 4);
            Console.WriteLine(this.penguin5Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 5);
            Console.WriteLine(this.penguin6Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 6);
            Console.WriteLine(this.penguin7Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 7);
            Console.WriteLine(this.penguin8Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 8);
            Console.WriteLine(this.penguin9Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 9);
            Console.WriteLine(this.penguin10Row.ToString());
            Console.SetCursorPosition(this.Coll, this.Row + 10);
            Console.WriteLine(this.penguin11Row.ToString());
            
        }

        public void Render()
        {
        penguin1Row.Append(@"     _");
        penguin2Row.Append(@"   .' '.");
        penguin3Row.Append(@"   |'V'|");
        penguin4Row.Append(@"   /.-.\");
       penguin5Row.Append(@"  //   \\");
     penguin6Row.Append(@".',|   |,'.");
     penguin7Row.Append(@"|/||   ||\|");
       penguin8Row.Append(@"  ||   ||");
       penguin9Row.Append(@"  \\___//");
      penguin10Row.Append(@"  / \ / \");
      penguin11Row.Append(@"  '`' '`'");
        }
    }
}
