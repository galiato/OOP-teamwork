using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSmartPenguin
{
    public abstract class GameObject : IRenderable
    {
        public GameObject(Coords position)
        {
            this.Position = position;
        }

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
                this.position = value;
            }
        }
       

    }
}
