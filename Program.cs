using Raylib_cs;
using Greed_Game.Game;
using Greed_Game.Game.Casting;

int width = 500;
int height = 500;
Color bgColor = new Color(100,100,150,255);
int FPS = 60;
string title = "Greed";

VideoService videoService = new VideoService(width,height,bgColor,title,FPS);
Director director = new Director(videoService);

Cast cast = new Cast();
cast.Add("players", new Player());
cast.Add("banners", new Banner());

director.StartGame(cast);