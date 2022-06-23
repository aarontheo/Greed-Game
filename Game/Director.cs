using System;
using Greed_Game.Game.Casting;

namespace Greed_Game.Game
{
    public class Director
    {
        private VideoService videoService;
        //private InputService inputService;

        public Director(VideoService videoService)
        {
            this.videoService = videoService;
            //this.inputService = inputService;
        }
        public void StartGame(Cast cast)
        {
            //GetInputs(cast);
            Update(cast);
            Draw(cast);
        }
        // public void GetInputs(Cast cast)
        // {
        //     Actor player = cast.GetFirstActor("player");
        //     Point dir = inputService.GetDirection();
        //     player.vel += dir;
        // }
        public void Update(Cast cast)
        {
            cast.Update(videoService.width,videoService.height);
        }
        public void Draw(Cast cast)
        {
            
        }
    }
}