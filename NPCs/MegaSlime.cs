using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.NPCs
{
	public class MegaSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mega Slime");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.aiStyle = 1;
			npc.damage = 20;
			npc.defense = 3;
			npc.lifeMax = 100;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 8000f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.05f;
		}

        public override void NPCLoot()
        {
			Item.NewItem(npc.getRect(), mod.ItemType("MegaGel"), 5);
			if (Main.rand.NextFloat() < .20f)
				Item.NewItem(npc.getRect(), mod.ItemType("GravityTalisman"), 1);

		}
    }
}