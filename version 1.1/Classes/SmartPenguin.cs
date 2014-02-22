using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    //public class SmartPenguin : MovingObject, IDefence
    //{
        
    //}

    //author dimitermandov
    public class SmartPenguin : GameItems, IDefence
    {
        public static readonly string[] PLAYER_SYMBOL = new string[] {
            "    00>>  ",
            "    ||  ",
            "   //=\\\\ ",
            "  //= =\\\\ ",
            "<<       >>"
         };

        

        private int playerPositionX; 
        private int playerPositionY;

        public SmartPenguin(int playerPositionX, int playerPositionY)
            : base(playerPositionX, playerPositionY)
        {
            this.playerPositionX = playerPositionX;
            this.playerPositionY = playerPositionY;
        }

        public override void ShowPosition()
        {
            int row = 0;
            foreach (string playerSymbolRow in PLAYER_SYMBOL)
            {
                DrawItem.Draw(this.playerPositionX, playerPositionY + row, playerSymbolRow);
                row++;
            }
        }
    }

}
