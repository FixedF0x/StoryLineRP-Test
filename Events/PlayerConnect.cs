using AltV.Net;
using AltV.Net.Async;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using StoryLineRP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoryLineRP.Events
{
    class PlayerConnect : Singleton<PlayerConnect>, IScript
    {
        private readonly Position _spawnPosition = new Position(0, 0, 72);

        public PlayerConnect()
        {
            AltAsync.Log("PlayerConnect registered");

            AltAsync.OnPlayerConnect += AltAsync_OnPlayerConnect;
        }

        // hier könnte man theoretisch auch ein eigenes Player-Object usen, ist für die Testaufgabe aber irrelevant :D
        private async Task AltAsync_OnPlayerConnect(IPlayer player, string reason)
        {
            await player.SpawnAsync(_spawnPosition);
            await player.SetModelAsync((uint)PedModel.Chimp);
            await player.GiveWeaponAsync((uint)WeaponModel.AssaultRifle, 5, true);
        }
    }
}
