using Raylib_cs;
using Greed_Game.Game;
using Greed_Game.Game.Casting;

int width = 500;
int height = 500;
Color bgColor = new Color(0,0,0,255);
int FPS = 20;
string title = "Greed";

VideoService videoService = new VideoService(width,height,bgColor,title,FPS);
Director director = new Director(videoService);

Cast cast = new Cast();
cast.Add("players", new Player(width/2,height-50,"@"));
cast.Add("banners", new Actor(0,0,"Points: "));

director.StartGame(cast);