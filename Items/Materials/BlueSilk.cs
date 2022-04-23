using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Materials
{
	public class BlueSilk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Silk");
			Tooltip.SetDefault("Vanities are cool!");
		}

		public override void SetDefaults()
		{
			item.material = true;
			item.maxStack = 999;
			item.width = 40;
			item.height = 40;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 1);
			recipe.AddIngredient(ItemID.Cobweb, 20);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}