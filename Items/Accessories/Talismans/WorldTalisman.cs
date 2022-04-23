using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using NientasEssentials.Items.Tiles;

namespace NientasEssentials.Items.Accessories.Talismans
{
	public class WorldTalisman : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("World Talisman");
			Tooltip.SetDefault("Dude, you expect me to know what to tell you...");
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
			player.lifeRegenTime = 4;
			player.lifeRegen = 5;
			player.manaRegen = 10;
			player.jumpSpeedBoost = 0.5f;
			player.statDefense = 5;
			player.moveSpeed = 1.2f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 2);
			recipe.AddIngredient(ItemID.DirtBlock, 100);
			recipe.AddTile(ModContent.TileType<BlueWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}