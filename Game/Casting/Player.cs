using System;
using Greed_Game.Game.Casting;
using Greed_Game.Game;

namespace Greed_Game.Game.Casting
{
    public class Player : Actor
    {
        public Player(int x, int y,string text,int fontSize=30):base(x,y,text)
        {
            // this.pos = new Vect(x,y);
            // this.text = text;
            // this.fontSize = fontSize;
        }
        InputService inputS = new InputService();
        float speedLimit = 0.5f;
        float decel = 0.96f; //between 0 and 1, higher values are more floaty
        float accel = 0.01f;
        public override void Update(int maxX, int maxY)
        {
            vel += inputS.GetDirection() * accel; //change velocity based on input
            vel = vel.Clamp(speedLimit);
            base.Update(maxX, maxY);
            vel *= decel;
            //this bit allows for screen wraparound
            if (pos.x > maxX || pos.x < 0 - fontSize)
            {
                if (pos.x < 0 - fontSize)
                {
                    pos.x = maxX;
                }
                else
                {
                    pos.x = 0 - fontSize;
                }
            }
            if (pos.y > maxY || pos.y < 0 - fontSize)
            {
                if (pos.y < 0 - fontSize)
                {
                    pos.y = maxY;
                }
                else
                {
                    pos.y = 0 - fontSize;
                }
            }

        }
    }
}
