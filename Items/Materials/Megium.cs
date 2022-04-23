using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Materials
{
	public class Megium : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Megium");
			Tooltip.SetDefault("Two Eternal Forces combined...");
		}

		public override void SetDefaults()
		{
			item.material = true;
			item.maxStack = 99;
			item.width = 40;
			item.height = 40;
			item.value = 300;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 1);
			recipe.AddIngredient(mod.ItemType("Crackium"), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}