using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_1._1
{
    public abstract class Player
    {
        private const int LIFE = 200;
        public static int playerLife = LIFE;

        private int name;
                

        public int Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual int Move()
        {
            return 0;
        }

        public abstract void ShowPosition();
        



    }
}
