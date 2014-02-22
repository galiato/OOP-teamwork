﻿namespace version_1._1
{
    using System;

    class InfoAreas

    {
        const string SYMBOL = "|";
        const string SYMBOL_QUESTION_AREA = "_";

        public static void Initialize()
        {
            for (int row = 0; row < WindowsSettings.INFO_AREA_HEIGHT; row++)
            {
                DrawItem.Draw(WindowsSettings.INFO_AREA_WIDTH, row, SYMBOL);
            }

            DrawItem.Draw(WindowsSettings.INFO_AREA_WIDTH + 2, 4, "Press M to Mute!");
            DrawItem.Draw(WindowsSettings.INFO_AREA_WIDTH + 2, 6, "Press P for Pause!");
            DrawItem.Draw(WindowsSettings.INFO_AREA_WIDTH + 2, 8, "Press ESC to quit!");
            // DrawItem.Draw(WindowsSettings.INFO_AREA_WIDTH + 2, 44, "Time: " + StartGame.secondsToGameOver);
            DrawItem.Draw(WindowsSettings.INFO_AREA_WIDTH + 2, 21, "Scores: " + Scores.currentScores);
            // DrawItem.Draw(WindowsSettings.INFO_AREA_WIDTH + 2, 26, "Level: 1");                    

            DrawItem.Draw(WindowsSettings.INFO_AREA_WIDTH + 2, 20, "Life Points: " + Player.playerLife);
            

            for (int col = 0; col < WindowsSettings.INFO_AREA_WIDTH; col++)
            {
                DrawItem.Draw(col, WindowsSettings.INFO_AREA_HEIGHT-10,  SYMBOL_QUESTION_AREA);
            }
            DrawItem.Draw(1,  WindowsSettings.INFO_AREA_HEIGHT-9, "Please answer the question: " + Questions.question);
        }
    }
}