using AltV.Net.Async;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Interactions;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StoryLineRP.Models.Interactions
{
    public class EquipInteraction : Interaction
    {
        public WeaponModel WeaponModel { get; set; }

        public EquipInteraction(Position pos, ulong id, WeaponModel weaponModel) : base((ulong)InteractionTypes.EQUIP, id, pos, 0, 5)
        {
            WeaponModel = weaponModel;
        }

        public override bool OnInteraction(IPlayer player, Vector3 interactionPosition, int interactionDimension)
        {
            player.GiveWeapon((uint)WeaponModel, 100, true);
            player.EmitLocked("drawNotification", "CHAR_AMMUNATION", "Equippunkt", $"Waffe: {Enum.GetName(typeof(WeaponModel), WeaponModel)}", "Du hast eine Waffe equipt.");

            return true;
        }
    }
}
