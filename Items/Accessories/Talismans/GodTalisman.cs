using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Accessories.Talismans
{
	public class GodTalisman : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("God Talisman");
			Tooltip.SetDefault("POWER!");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 3000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lavaImmune = true;
			player.breathMax = 400;
			player.fishingSkill = 75;
			player.jumpSpeedBoost = 4f;
			player.lifeRegenTime = 2;
			player.lifeRegen = 40;
			player.statDefense = 15;
			player.moveSpeed = 1.5f;
			player.manaRegen = 30;
			player.noFallDmg = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 30);
			recipe.AddIngredient(mod.ItemType("BreathingTalisman"), 1);
			recipe.AddIngredient(mod.ItemType("GravityTalisman"), 1);
			recipe.AddIngredient(mod.ItemType("WorldTalisman"), 1);
			recipe.AddIngredient(mod.ItemType("HealthTalisman"), 1);
			recipe.AddIngredient(mod.ItemType("FishingTalisman"), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}