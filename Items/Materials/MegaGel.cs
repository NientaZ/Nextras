using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Materials
{
	public class MegaGel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mega Gel");
			Tooltip.SetDefault("A true essential!");
		}

		public override void SetDefaults()
		{
			item.material = true;
			item.maxStack = 999;
			item.width = 40;
			item.height = 40;
			item.value = 300;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 6);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}