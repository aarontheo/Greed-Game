using System;
using Raylib_cs;

namespace Greed_Game.Game
{
    public class VideoService
    {
        private int framerate = 0;
        private int width;
        public int height;
        public Color BGColor { get; set; }
        public VideoService(int width,int height,Color BGColor,int framerate = 60)
        {
            this.width = width;
            this.height = height;
            this.BGColor = BGColor;
        }
        public void OpenWindow(int width, int height,string title)
        {
            Raylib.InitWindow(width, height, title);
        }
        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }
        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(BGColor);
        }
        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }
    }
}
