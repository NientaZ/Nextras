using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Accessories.GelCollectionA
{
	public class GelAglet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Aglet");
			Tooltip.SetDefault("Wow! Much Fast! Very Smooth!");
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
			player.statDefense += 2;
			player.accRunSpeed = 2f;
			player.maxRunSpeed = 4f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 50);
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddIngredient(ItemID.Aglet, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}