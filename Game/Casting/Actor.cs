using System;
using Raylib_cs;


//TODO: Maybe change the pos Vect back to a point?
namespace Greed_Game.Game.Casting
{
    public class Actor
    {
        public Vect pos;
        public int fontSize { get; set; }
        public Vect vel = new Vect(0,0);
        public string text { get; set; }
        public Color color;

        public Actor(int x = 0, int y = 0,string text = "@",int fontSize = 5)
        {
            pos = new Vect(x, y);
            this.text = text;
            this.fontSize = fontSize;
            this.color = new Color(50,50,50,255);
        }
        public void Draw()
        {
            Raylib.DrawText(text,((int)pos.x),((int)pos.y),fontSize,color);
        }
        public virtual void Update(int maxX, int maxY)
        {
            pos = pos + vel;
        }
        public Rectangle getBound()
        {
            return new Rectangle(pos.x, pos.y, fontSize, fontSize);
        }
        public bool isColliding(Actor b)
        {
            return Raylib.CheckCollisionRecs(this.getBound(), b.getBound());
        }
    }
}
