using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Tools.WoodCollection
{
	public class WoodenPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Pickaxe");
			Tooltip.SetDefault("The Beginner's Pickaxe!");
		}

		public override void SetDefaults()
		{
			item.pick = 30;
			item.damage = 2;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 150;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}