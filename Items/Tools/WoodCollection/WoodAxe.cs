using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Tools.WoodCollection
{
	public class WoodAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Axe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Because a wooden axe doesn't exist in vanilla...");
		}

		public override void SetDefaults()
		{
			item.axe = 30;
			item.damage = 3;
			item.width = 40;
			item.height = 40;
			item.useTime = 50;
			item.useAnimation = 27;
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