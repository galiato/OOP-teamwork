using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    public class Engine
    {
        public Engine(IRenderer renderer, IObjectOperator objectOperator)
        {
            this.renderer = renderer;
            this.allObjects = new List<GameObject>();
            this.ObjOperator = objectOperator;
        }

        private List<GameObject> allObjects;
        private IRenderer renderer;
        private IObjectOperator objOperator;
        private byte PlayersCount;
        public static Random rndGen = new Random();

        public IObjectOperator ObjOperator
        {
            get { return this.objOperator; }
            set
            {
                if (null == value) throw new ArgumentNullException("Object operator can not be null!");
                this.objOperator = value;
            }
        }

        private void AddGameObject(GameObject obj)
        {
            this.allObjects.Add(obj);
        }
        private void AddGameObject(IEnumerable<GameObject> gameObjects)
        {
            this.allObjects.AddRange(gameObjects);
        }

        public void Run()
        {
            Console.Write("Choose Players' count: ");
            string command = Console.ReadLine();
            while (byte.TryParse(command, out this.PlayersCount) == false && this.PlayersCount>4)
            {
                Console.Write("Choose Players' count: ");
                command = Console.ReadLine();

            }



            //TODO:
            //Create a fish
            this.AddGameObject(objOperator.MainObjectsProducer("", "Fish", "1"));
            //Create this.PlayersCount number of penguins with given names
            for (int i = 1; i <= this.PlayersCount; i++)
            {
                Console.WriteLine("Player {0} name: ", i);
                string plName = Console.ReadLine();
                this.AddGameObject(objOperator.MainObjectsProducer(plName, "SmartPenguin", i.ToString()));
            }


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
