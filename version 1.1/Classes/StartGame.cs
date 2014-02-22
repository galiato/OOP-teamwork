namespace version_1._1
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

                SmartPenguin penguin = new SmartPenguin(WindowsSettings.GAME_AREA_WIDTH / 2 - 3, WindowsSettings.GAME_AREA_HEIGHT - PLAYER_HEIGHT- 10);
                penguin.ShowPosition();
                Enemies enemy = new Enemies(WindowsSettings.GAME_AREA_WIDTH / 2 - 40, WindowsSettings.GAME_AREA_HEIGHT - PLAYER_HEIGHT - 45);
                enemy.ShowPosition();

                //// CODE FOR TIME starts //
                //timeSpan1 = diagnoze.Subtract(stopWatch1.Elapsed);
                //secondsToGameOver = String.Format("{0}", timeSpan1.Seconds.ToString("00"));
                Thread.Sleep(100);
                
            }
        }
    }
}
