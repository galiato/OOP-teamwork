using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    public class Engine
    {
        public Engine(IRenderer renderer)
        {
            this.renderer = renderer;
            this.allObjects = new List<GameObject>();
        }

        private List<GameObject> allObjects;
        private IRenderer renderer;
        private byte PlayersCount;
        public static Random rndGen = new Random();

        private void AddGameObject(GameObject obj)
        {
            this.allObjects.Add(obj);
        }

        public void Run()
        {
            Console.Write("Choose Players' count: ");
            string command = CommandParser();
            while (byte.TryParse(command, out this.PlayersCount) == false)
            {
                Console.Write("Choose Players' count: ");
                command = CommandParser();
            }

            SmartPenguin peng = new SmartPenguin("Misho", new Coords(6, 6), new Coords(0, 0));
            this.AddGameObject(peng);
            for (int i = 0; i < peng.Shape.GetLength(0); i++)
            {
                for (int j = 0; j < peng.Shape.GetLength(1); j++)
                {
                    Console.Write(peng.Shape[i, j]);
                }
                Console.WriteLine();
            }
            //TODO:
            //Create this.PlayersCount number of penguins with given names
            //Generate random count of enemies and friends at random positions
            //Print them all on the game area
            //Load first question
            //Enter the game loop
            while (command != "exit")
            {

                command = CommandParser();

            }

        }
        private string CommandParser()
        {
            string command = Console.ReadLine();
            switch (command)
            {
                case "":
                    break;
                default: Console.WriteLine("Do something");
                    break;
            }

            return command;

        }
    }
}
