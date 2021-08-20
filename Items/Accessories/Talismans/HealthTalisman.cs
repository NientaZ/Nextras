using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Accessories.Talismans
{
	public class HealthTalisman : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Health Talisman");
			Tooltip.SetDefault("That's a very very good question...");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 300;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lifeRegenTime = 2;
			player.lifeRegen = 20;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 3);
			recipe.AddIngredient(ItemID.HealingPotion, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}