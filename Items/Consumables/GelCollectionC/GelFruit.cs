using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using NientasEssentials.Items.Tiles;

namespace NientasEssentials.Items.Consumables.GelCollectionC
{
	public class GelFruit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Fruit");
			Tooltip.SetDefault("Gel Fruit is epic!");
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 200;
			item.useAnimation = 20;
			item.useStyle = 2;
			item.maxStack = 99;
			item.healLife = 30;
			item.value = 150;
			item.rare = 4;
			item.UseSound = SoundID.Item3;
			item.autoReuse = false;
			item.potion = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 1);
			recipe.AddIngredient(ItemID.LesserHealingPotion, 1);
			recipe.AddTile(ModContent.TileType<BlueWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}