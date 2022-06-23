using System;

namespace Greed_Game.Game.Casting
{
    public class Collectible: Actor
    {
        public int pointValue;
        public Collectible(int x,int y,int pointValue,int speed = 5)
        {
            pos = new Vect(x, y);
            //this.pointValue = pointValue;
            this.pointValue = speed*2;
            this.vel.y = speed;
        }
    }
}
