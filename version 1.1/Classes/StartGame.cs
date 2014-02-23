namespace TheSmartPenguin
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    class StartGame
    {
        public const int PLAYER_HEIGHT = 5;
        public const int PLAYER_WIDTH = 9;

        public static string secondsToGameOver;
        public static Stopwatch stopWatch1 = new Stopwatch();
        const int INTERVAL = 100;

        public static void Initialize()
        {
            stopWatch1.Reset();
            stopWatch1.Start();

            //Sound.StopMenuMusic();
            //Sound.PlayIngameMusic();

            TimeSpan timeSpan1 = new TimeSpan();

            TimeSpan diagnoze = DateTime.Now.AddSeconds(30) - DateTime.Now; // change AddSeconds(int) with the game time
            timeSpan1 = diagnoze.Subtract(stopWatch1.Elapsed);
            secondsToGameOver = String.Format("{0}", timeSpan1.Seconds.ToString("00"));

            while (true)
            {
                Terrain.Initialize();

                InfoAreas.Initialize();
               char[,] penguinShape= new[,] { 
            {' ',' ',' ',' ',' ','_',' ',' ',' ',' ',' '},
            {' ',' ',' ','.','\'',' ','\'','.',' ',' ',' '},
            {' ',' ',' ','|','\'','V','\'','|',' ',' ',' '},
            {' ',' ',' ','/','.','-','.','\\',' ',' ',' '},
            {' ',' ',' ','/','/',' ','\\','\\',' ',' ',' '},
            {' ','.','\'',',','|',' ','|',',','\'','.',' '},
            {' ','|','/','|','|',' ','|','|','\\','|',' '},
            {' ',' ','\\','\\','_','_','/','/',' ',' ',' '},
            {' ',' ','/',' ','\\',' ','/',' ','\\',' ',' '},
            {' ',' ','\'','`','\'',' ','\'','`','\'',' ',' '}
            };
                SmartPenguin penguin = new SmartPenguin("pesho", new Coords(5,5), new Coords(1,1),penguinShape);
                penguin.Render();
                penguin.Print();
                //penguin.ShowPosition();
                Enemies enemy = new Enemies("pesho",new Coords(30,30),new Coords(1,1),new[,] {{'#'}});
                //enemy.ShowPosition();

                //// CODE FOR TIME starts //
                //timeSpan1 = diagnoze.Subtract(stopWatch1.Elapsed);
                //secondsToGameOver = String.Format("{0}", timeSpan1.Seconds.ToString("00"));
                //Thread.Sleep(100);   
            }
        }
    }
}
