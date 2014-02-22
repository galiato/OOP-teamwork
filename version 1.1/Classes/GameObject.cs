using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    public abstract class GameObject
    {
        private string name;



        public GameObject(string name, int row, int coll)
        {
            this.Name = name;
            this.Row = row;
            this.Coll = coll;
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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
