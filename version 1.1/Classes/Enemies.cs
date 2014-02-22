using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    public class Enemies : MovingObject, IAtack
    {
        //public static readonly string[] PLAYER_SYMBOL = new string[] {
        //    "     00  ",
        //    "     ||  ",
        //    "   <<==>> ",
        //    "   //= =\\\\ ",
        //    "<< >>   <<  >>"
        // };

        

        //private int playerPositionX; 
        //private int playerPositionY;

        //public Enemies(int playerPositionX, int playerPositionY)
        //    : base(playerPositionX, playerPositionY)
        //{
        //    this.playerPositionX = playerPositionX;
        //    this.playerPositionY = playerPositionY;
        //}

        //public override void ShowPosition()
        //{
        //    int row = 0;
        //    foreach (string playerSymbolRow in PLAYER_SYMBOL)
        //    {
        //        DrawItem.Draw(this.playerPositionX, playerPositionY + row, playerSymbolRow);
        //        row++;
        //    }
        //}

        public Enemies(string name, int row, int coll)
            : base(name, row, coll)
        { }

        public int AttackPoints
        {
            get { throw new NotImplementedException(); }
        }
    }
}
