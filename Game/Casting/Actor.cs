using System;
using Raylib_cs;

namespace Greed_Game.Game.Casting
{
    public class Actor
    {
        public Vect pos;
        public int fontSize { get; set; }
        public Vect vel = new Vect(0,0);
        public char icon { get; set; }
        public Color color;
        public Actor(int x = 0, int y = 0,char icon = '@',int fontSize = 5)
        {
            pos = new Vect(x, y);
            this.icon = icon;
            this.fontSize = fontSize;
            this.color = new Color(50,50,50);
        }
        public void Draw()
        {
            Raylib.DrawText(icon,pos.x,pos.y,fontSize,color);
        }
        public void Draw(int gridSize)
        {
            
        }
        public virtual void Update(int maxX, int maxY)
        {
            pos = pos + vel;
        }
    }
}
