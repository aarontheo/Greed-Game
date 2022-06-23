using System;
using Raylib_cs;
using Greed_Game.Game.Casting;

namespace Greed_Game.Game
{
    public class InputService
    {
        public Point GetDirection()
        {
            int dx = 0;
            int dy = 0;
            if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                dx -= 1;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                dx += 1;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                dy -= 1;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                dy += 1;
            }
            return new Point(dx,dy);
        }
    }
}
