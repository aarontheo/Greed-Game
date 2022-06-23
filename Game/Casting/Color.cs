using System;

namespace Greed_Game.Game.Casting
{
    public class Color
    {
        public byte r { get; set; }
        public byte g { get; set; }
        public byte b { get; set; }
        public byte a { get; set; }
        public Color(byte r,byte g,byte b,byte a = 255)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
        public Raylib_cs.Color toRaylibColor()
        {
            return new Raylib_cs.Color(this.r, this.g, this.b, this.a);
        }
    }
}