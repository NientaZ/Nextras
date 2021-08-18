using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Consumables.GelCollectionC
{
	public class GelFruit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Fruit"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
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
			recipe.AddIngredient(ItemID.Gel, 10);
			recipe.AddIngredient(ItemID.LesserHealingPotion, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}