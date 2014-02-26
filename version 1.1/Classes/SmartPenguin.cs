using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheSmartPenguin.Interfaces;

namespace TheSmartPenguin
{
    public class SmartPenguin : MovingObject, IDefense
    {
        public SmartPenguin(string name, Coords position, Coords direction)
            : base(position, direction)
        {
            this.Name = name;
            this.Shape = new[,] { 
            {' ',' ',' ',' ','_',' ',' ',' ',' ',' '},
            {' ',' ','.','\'',' ','\'','.',' ',' ',' '},
            {' ',' ','|','\'','V','\'','|',' ',' ',' '},
            {' ',' ','/','.','-','.','\\',' ',' ',' '},
            {' ',' ','/','/',' ',' ','\\','\\',' ',' '},
            {'.','\'',',','|',' ',' ','|',',','\'','.'},
            {'|','/','|','|',' ',' ','|','|','\\','|'},
            {' ',' ','\\','\\','_','_','/','/',' ',' '},
            {' ',' ','/',' ','\\','/',' ','\\',' ',' '},
            {' ',' ','\'','`','\'','\'','`','\'',' ',' '}
            };
            this.Enemies = new List<Enemy>();
        }
        private string name;
        private List<Enemy> enemies;

        public List<Enemy> Enemies
        {
            get { return this.enemies; }
            set
            {
                if (null == value) throw new ArgumentNullException("Enemies can not be null");
                this.enemies = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null) throw new ArgumentNullException("Name can not be null!");
                this.name = value;
            }
        }
        public int DefensePoints
        {
            get { return 100; }
        }

        public override void Update()
        {
            this.Position += this.Direction;
        }



    }
}
