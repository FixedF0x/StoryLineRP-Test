using AltV.Net;
using AltV.Net.Interactions;
using StoryLineRP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryLineRP.Core
{
    class Gamemode : Singleton<Gamemode>, IScript
    {
        public void StartGamemode()
        {
            AltInteractions.Init();
        }

        public void StopGamemode()
        {
            AltInteractions.Dispose();
        }
    }
}
