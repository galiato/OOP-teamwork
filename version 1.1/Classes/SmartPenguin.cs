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
    public class SmartPenguin : Player, IDefence
    {
        public static readonly string[] PLAYER_SYMBOL = new string[] {
            "   ( )   ",
            "    =    ",
            "  //=\\ ",
            "|// = \\|",
            "|@@=-=@@|"
        };

        public const int PLAYER_HEIGHT = 5;
        public const int PLAYER_WIDTH = 9;

        public override void ShowPosition()
        {
            throw new NotImplementedException();
        }
    }

}
