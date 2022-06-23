using System;
using Greed_Game.Game;

namespace Greed_Game.Game.Casting
{
    public class Player:Actor
    {
        InputService inputS = new InputService();
        float SpeedLimit = 5;
        public override void Update(int maxX, int maxY)
        {
            vel += inputS.GetDirection(); //change velocity based on input
            vel = vel.Clamp(SpeedLimit);
            base.Update(maxX, maxY);
        }
    }
}
