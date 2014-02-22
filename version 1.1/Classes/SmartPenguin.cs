using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    public class SmartPenguin : MovingObject, IDefence
    {
        public SmartPenguin(string name, ScreenCoordinates coordinates)
            : base(name)
        { }

        public int DefencePoints
        {
            get { return 100; }
        }
    }

    //author dimitermandov
    //public class SmartPenguin : Player, IDefence
    //{
    //    public static readonly string[] PLAYER_SYMBOL = new string[] {
    //        "    00>>  ",
    //        "    ||  ",
    //        "   //=\\ ",
    //        "  //= =\\ ",
    //        "<<       >>"
    //     };

        

    //    private int playerPositionX; 
    //    private int playerPositionY; 
    //    public SmartPenguin (int playerPositionX, int playerPositionY)
    //    {
    //        this.playerPositionX = playerPositionX;
    //        this.playerPositionY = playerPositionY;
    //    }

    //    public int PlayerPositionX
    //    {
    //        get { return playerPositionX; }
    //        set { this.playerPositionX = value; }
    //    }

    //    public int PlayerPositionY
    //    {
    //        get { return playerPositionY; }
    //        set { this.playerPositionY = value; }
    //    }
    //    public override void ShowPosition()
    //    {
    //        int row = 0;
    //        foreach (string playerSymbolRow in PLAYER_SYMBOL)
    //        {
    //            DrawItem.Draw(this.playerPositionX, playerPositionY + row, playerSymbolRow);
    //            row++;
    //        }
    //    }
    //}

}
