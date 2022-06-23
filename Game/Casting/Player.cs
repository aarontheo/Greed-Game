using System;
using Greed_Game.Game.Casting;
using Greed_Game.Game;

namespace Greed_Game.Game.Casting
{
    public class Player:Actor
    {
        InputService inputS = new InputService();
        float speedLimit = 0.5f;
        float decel = 0.2f; //between 0 and 1, higher values are more floaty
        float accel = 0.06f;
        public override void Update(int maxX, int maxY)
        {
            vel += inputS.GetDirection()*0.1f; //change velocity based on input
            vel = vel.Clamp(speedLimit);
            base.Update(maxX, maxY);
            vel *= decel;
        }
    }
}
