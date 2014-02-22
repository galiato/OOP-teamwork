namespace version_1._1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class GameItems
    {
        
        private int playerPositionX; 
        private int playerPositionY;
 
        protected GameItems (int playerPositionX, int playerPositionY)
        {
            this.playerPositionX = playerPositionX;
            this.playerPositionY = playerPositionY;
        }

        public int PlayerPositionX
        {
            get { return playerPositionX; }
            set { this.playerPositionX = value; }
        }

        public int PlayerPositionY
        {
            get { return playerPositionY; }
            set { this.playerPositionY = value; }
        }
        
        public abstract void  ShowPosition();
       
        
    }
}
