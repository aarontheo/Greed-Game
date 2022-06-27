using System;
using Raylib_cs;
using Greed_Game.Game.Casting;

namespace Greed_Game.Game
{
    public class Director
    {
        private VideoService videoService;
        private Random rng = new Random(1337);
        //private InputService inputService;
        private int score = 0;
        private int spawnCounter = 0;
        private int spawnInterval = 1500;
        public Director(VideoService videoService)
        {
            this.videoService = videoService;
            //this.inputService = inputService;
        }
        public void StartGame(Cast cast)
        {
            videoService.OpenWindow();
            while (!Raylib.WindowShouldClose())
            {
                //GetInputs(cast);
                Update(cast);
                videoService.ClearBuffer();
                Draw(cast);
                videoService.FlushBuffer();
            }
            videoService.CloseWindow();
            Console.WriteLine("Program Ended!");
        }
        // public void GetInputs(Cast cast)
        // {
        //     Actor player = cast.GetFirstActor("player");
        //     Point dir = inputService.GetDirection();
        //     player.vel += dir;
        // }
        public void Update(Cast cast)
        {
            //randomly spawn gems/rocks
            if (spawnCounter >= spawnInterval)
            {
                spawnCounter = 0;
                int value = rng.Next(3, 4);
                int which = (int) Math.Round(rng.NextSingle());
                int x = rng.Next(videoService.width);
                cast.Add("collectibles", new Collectible(x-(x%30), 0, value));
                value = rng.Next(-5, -2);
                x = rng.Next(videoService.width);
                cast.Add("collectibles", new Collectible(x-(x%30), 0, value));
            }
            var player = cast.GetFirstActor("players");
            foreach (Collectible thing in cast.GetActors("collectibles"))
            {
                if (player.isColliding(thing))
                {
                    score += thing.pointValue;
                    cast.Remove("collectibles", thing);
                }
                if (thing.pos.y > videoService.height)
                {
                    cast.Remove("collectibles", thing);
                }
            }
            cast.GetFirstActor("banners").text = $"Points: {score}";
            cast.Update(videoService.width,videoService.height);
            spawnCounter++;
        }
        public void Draw(Cast cast)
        {
            cast.Draw();
        }
    }
}