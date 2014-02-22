using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace version_1._1
{
    public abstract class MovingObject : GameObject, IMove
    {
        private int lifePoints;

        public MovingObject(string name)
            : base(name)
        {
            this.LifePoints = 0;
        }

        public int LifePoints
        {
            get { return lifePoints; }
            set { lifePoints = value; }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
