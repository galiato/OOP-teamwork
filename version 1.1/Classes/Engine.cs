using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    public class Engine
    {
        public Engine(IRenderer renderer, IObjectOperator objectOperator, IQuestionManager questionManager)
        {
            this.renderer = renderer;
            this.allObjects = new List<GameObject>();
            this.ObjOperator = objectOperator;
            this.questionManager = questionManager;

        }

        private List<GameObject> allObjects;
        private IRenderer renderer;
        private IObjectOperator objOperator;
        private IQuestionManager questionManager;
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

        public void Initialize()
        {
            string command = "initial";
            while (byte.TryParse(command, out this.PlayersCount) == false)
            {
                Console.Write("Choose Players' count: ");
                command = Console.ReadLine();
            }

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

        }
        public void Run()
        {
            //Question.GetQuestion();
            //char answer = char.Parse(Console.ReadLine());
            //Question.CheckQuestion(answer); //Връща bool

            //Enter the game loop
            string command = "initial";
            while (command != "exit")
            {
                CyclePlayers();
                command = CommandParser();
            }
        }

        private void CyclePlayers()
        {
            var penguins = allObjects.Where(t => t.GetType() == typeof(SmartPenguin)).Select(p => p as SmartPenguin).ToList();
            for (int player = 1; player <= this.PlayersCount; player++)
            {
                IQuestion q = questionManager.GetQuestion();
                questionManager.PrintQuestion(q);
                string input = Console.ReadLine();
                if (q.InputForRightAnswer == input)
                {
                    penguins[player - 1].Update();
                }
                else
                {
                    UpdateRelatedEnemies(penguins[player - 1]);
                }
            }
        }
        private void AssignEnemies(SmartPenguin penguin)
        {
            //TODO: add to each penguin's Enemies List the nearest enemies
        }
        private void UpdateRelatedEnemies(SmartPenguin smartPenguin)
        {
            foreach (var enemy in smartPenguin.Enemies)
            {
                //TODO: Move the enemy a step in the penguin's direction

            }
        }

        private string CommandParser()
        {
            string command = Console.ReadLine();
            switch (command)
            {
                case "start":
                    RunQuiz();
                    break;
                default: Console.WriteLine("Do something");
                    break;
            }

            return command;

        }

        private void RunQuiz()
        {
            Question.GetQuestion();
            string cmd = Console.ReadLine();
        }
    }
}
