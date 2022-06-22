using System;

namespace Greed_Game.Game.Casting
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator +(Point a,Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
    }
}
