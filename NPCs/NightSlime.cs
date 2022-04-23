using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.NPCs
{
	public class NightSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Slime");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.aiStyle = 1;
			npc.damage = 30;
			npc.defense = 6;
			npc.lifeMax = 40;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 8000f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.30f;
		}

        public override void NPCLoot()
        {
			Item.NewItem(npc.getRect(), mod.ItemType("MegaGel"), 4);
			if (Main.rand.NextFloat() < .10f)
				Item.NewItem(npc.getRect(), mod.ItemType("GelPellets"), 10);
			if (Main.rand.NextFloat() < .05f)
				Item.NewItem(npc.getRect(), mod.ItemType("CrackiumPellets"), 10);
			if (Main.rand.NextFloat() < .12f)
				Item.NewItem(npc.getRect(), mod.ItemType("Crackium"), 1);
		}
    }
}