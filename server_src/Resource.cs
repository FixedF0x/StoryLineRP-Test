using AltV.Net.Async;
using StoryLineRP.Core;
using StoryLineRP.Events;
using System;

namespace StoryLineRP
{
    public class Resource : AsyncResource
    {
        public override void OnStart()
        {
            AltAsync.Log("StoryLine-RP Test loaded.");
            Gamemode.Instance.StartGamemode();
        }

        public override void OnStop()
        {
            AltAsync.Log("StoryLine-RP Test unloaded.");
            Gamemode.Instance.StopGamemode();
        }
    }
}
