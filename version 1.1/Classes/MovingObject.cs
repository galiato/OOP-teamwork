﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public abstract class MovingObject : GameObject
    {
        public MovingObject(string name, Coords position, Coords direction,char[,] shape)
            : base(name, position, shape)
        {
            this.Direction = direction;
        }

        private Coords direction;

        public Coords Direction
        {
            get { return this.direction; }
            set { this.direction = value; }
        }
    }
}
