using AltV.Net.Async;
using StoryLineRP.Events;
using System;

namespace StoryLineRP
{
    public class Resource : AsyncResource
    {
        public override void OnStart()
        {
            AltAsync.Log("StoryLine-RP Test loaded.");
        }

        public override void OnStop()
        {
            AltAsync.Log("StoryLine-RP Test unloaded.");
        }
    }
}
