using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using NientasEssentials.Items.Tiles;

namespace NientasEssentials.Items.Tools.GelCollectionT
{
	public class GelHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Hammer");
			Tooltip.SetDefault("Cheap Hammer that Works!");
		}

		public override void SetDefaults()
		{
			item.hammer = 25;
			item.damage = 6;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 150;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 1);
			recipe.AddTile(ModContent.TileType<BlueWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}