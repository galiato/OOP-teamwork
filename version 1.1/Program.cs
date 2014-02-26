using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
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
            //  StartGame.Initialize();
            Terrain.Initialize();
            InfoAreas.Initialize();

            IRenderer renderer = new ConsoleRender(120,50);
            IObjectOperator objOperator = new ObjectOperator();
            IQuestionManager questionManager = new StoreQuestion();
            Engine myEngine = new Engine(renderer, objOperator, questionManager);
            myEngine.Initialize();
            myEngine.Run();
        }
    }
}
