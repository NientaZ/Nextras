using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.NPCs
{
	public class OldSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frail Slime");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.aiStyle = 1;
			npc.damage = 7;
			npc.defense = 2;
			npc.lifeMax = 45;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 4000f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.10f;
		}

        public override void NPCLoot()
        {
			Item.NewItem(npc.getRect(), mod.ItemType("MegaGel"), 1);
			if (Main.rand.NextFloat() < .05f)
				Item.NewItem(npc.getRect(), mod.ItemType("OldFart"), 1);
			if (Main.rand.NextFloat() < .07)
				Item.NewItem(npc.getRect(), mod.ItemType("Crackium"), 1);
			if (Main.rand.NextFloat() < .20f)
				Item.NewItem(npc.getRect(), mod.ItemType("GelPellet"), 10);
		}
    }
}