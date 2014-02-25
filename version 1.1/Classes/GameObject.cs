using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public abstract class GameObject
    {
        public GameObject(string name, Coords position, char[,] shape)
        {
            this.Name = name;
            this.Shape = shape;
            this.Position = position;
        }

        private string name;
        private Coords position;
        private char[,] shape;


        public char[,] Shape
        {
            get { return this.shape; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The GameObject's shape can not be null!");
                }
                this.shape = value;
            }
        }
        public Coords Position
        {
            get { return this.position; }
            set
            {
                //int width = value.X + this.Shape.GetLength(0);
                //int height = value.Y + this.Shape.GetLength(1);
                //if (width <= WindowsSettings.GAME_AREA_WIDTH ||
                //     height <= WindowsSettings.GAME_AREA_HEIGHT)
                //    throw new ArgumentOutOfRangeException("The coordinates of the object are outside the area!");
                this.position = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private int row;
        private int coll;

        public int Row
        {
            get { return this.row; }
            set
            {
                if (this.row < 0 || this.row > WindowsSettings.WIN_HEIGHT)
                {
                    throw new ArgumentException("Wrong row number!");
                }
                else
                {
                    this.row = value;
                }
            }

        }

        public int Coll
        {
            get { return coll; }
            set
            {
                if (this.coll < 0 || this.coll > WindowsSettings.WIN_WIDTH)
                {
                    throw new ArgumentException("Wrong coll number!");
                }
                else
                {
                    this.coll = value;
                }
            }
        }


    }
}
