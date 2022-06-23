using System;

namespace Greed_Game.Game
{
    public class Director
    {
        private VideoService videoService;
        private InputService inputService;
        public Director(VideoService videoService,InputService inputService)
        {
            this.videoService = videoService;
            this.inputService = inputService;
        }
        public void StartGame()
        {
            
        }
        public void GetInputs()
        {

        }
        public void Update()
        {

        }
        public void Draw()
        {
            
        }
    }
}