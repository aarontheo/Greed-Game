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
            this.x = x;
            this.y = y;
        }
        public static Vect operator +(Vect a,Vect b)
        {
            return new Vect(a.x + b.x, a.y + b.y);
        }
        public static Vect operator *(Vect a,float b)
        {
            return new Vect(a.x * b, a.y * b);
        }
        public Vect Neg()
        {
            return this * -1;
        }
        public Point toPoint()
        {
            return new Point(((int)x), ((int)y));
        }
    }
}
