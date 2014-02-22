using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    public abstract class GameObject
    {
        private string name;

        public GameObject() { }

        public GameObject(string name, ScreenCoordinates coordinates)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
