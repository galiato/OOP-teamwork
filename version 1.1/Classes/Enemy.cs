﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public class Enemy : MovingObject, IAtack
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

        public Enemy( Coords position, Coords direction, char[,] shape)
            : base( position, direction)
        {
            this.Shape = shape;
        }

        public int AttackPoints
        {
            get { throw new NotImplementedException(); }
        }
    }
}
