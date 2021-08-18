﻿using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Accessories.GelCollectionA
{
	public class GelShoes : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Shoes");
			Tooltip.SetDefault("Bounce! Well, not really... still negates fall damage tho.");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 300;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statDefense += 4;
			player.noFallDmg = true;
			player.accRunSpeed = 2f;
			player.maxRunSpeed = 4f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 50);
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}