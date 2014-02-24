﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSmartPenguin
{
    public static class WindowsSettings
    {
        public const int WIN_HEIGHT = 50;
        public const int WIN_WIDTH = 170;
        public const int INFO_AREA_WIDTH = WIN_WIDTH - 20;
        public const int INFO_AREA_HEIGHT = WIN_HEIGHT;
        public const int GAME_AREA_WIDTH = WIN_WIDTH - 20;
        public const int GAME_AREA_HEIGHT = WIN_HEIGHT;

        private const ConsoleColor WIN_BACKGROUND = ConsoleColor.Black;
        private const ConsoleColor WIN_TEXT = ConsoleColor.White;

        public static void Initialize()
        {
            Console.Title = ("Smart Penguin");
            Console.BufferHeight = Console.WindowHeight = WIN_HEIGHT;
            Console.BufferWidth = Console.WindowWidth = WIN_WIDTH;
            Console.BackgroundColor = WIN_BACKGROUND;
            Console.Clear();
            Console.ForegroundColor = WIN_TEXT;
            Console.CursorVisible = false;
        }

    }
}
