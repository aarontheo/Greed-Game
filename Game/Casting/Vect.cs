using System;

namespace Greed_Game.Game.Casting
{
    /// <summary>
    /// Simple implementation of 2d vectors.
    /// </summary>
    public class Vect
    {
        public float x { get; set; }
        public float y { get; set; }
        public Vect(float x,float y)
        {
            
        }
        public static Vect operator +(Vect a,Vect b)
        {
            return new Vect(a.x + b.x, a.y + b.y);
        }
    }
}
