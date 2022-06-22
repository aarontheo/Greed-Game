using System;

namespace Greed_Game.Game.Casting
{
    public class Collectible: Actor
    {
        public int pointValue;
        public Collectible(int pointValue,int speed = 5)
        {
            this.pointValue = pointValue;
            this.vel.y = speed;
        }
    }
}
