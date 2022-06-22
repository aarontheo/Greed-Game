using System;
using Raylib_cs;

namespace Greed_Game.Game
{
    public class VideoService
    {
        public void OpenWindow(int width, int height)
        {
            Raylib.InitWindow(width, height, "Greed");
        }
    }
}
