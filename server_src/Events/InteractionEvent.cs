using AltV.Net;
using AltV.Net.Async;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Interactions;
using StoryLineRP.Models;
using StoryLineRP.Models.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryLineRP.Events
{
    class InteractionEvent : Singleton<InteractionEvent>, IScript
    {
        public InteractionEvent()
        {
            // hier könnte man jetzt theoretisch:
            // den Code modularieren & Interactions für jedes Module aus der Datenbank laden ^.^
            // just proof of concept
            EquipInteraction equipInteraction = new EquipInteraction(new Position(0, 0, 72), 1, WeaponModel.AdvancedRifle);
            AltInteractions.AddInteraction(equipInteraction);

            AltAsync.OnClient<IPlayer>("KeyPressE", KeyPressE);
        }

        private async void KeyPressE(IPlayer player)
        {
            var interactions = await AltInteractions.FindInteractions(await player.GetPositionAsync(), await player.GetDimensionAsync());
            foreach (var interaction in interactions)
            {
                if (interaction is EquipInteraction)
                {
                    if (interaction.OnInteraction(player, await player.GetPositionAsync(), await player.GetDimensionAsync())) break;
                }
            }
        }
    }
}
