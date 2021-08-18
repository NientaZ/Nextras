using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Tools.GelCollectionT
{
	public class GelAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Axe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("For all of your bouncy tree-chopping needs!");
		}

		public override void SetDefaults()
		{
			item.axe = 25;
			item.damage = 6;
			item.width = 40;
			item.height = 40;
			item.useTime = 40;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 150;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 60);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.CopperAxe, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}