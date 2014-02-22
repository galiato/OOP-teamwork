using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version_1._1
{
    class Program
    {
        static void Main()
        {
            // WINDOW Settings
            WindowsSettings.Initialize();

            // INITIAL Start Menu
            StartMenu.Initialize();

            // INITIAL THE GAME
            StartGame.Initialize();
        }
    }
}
