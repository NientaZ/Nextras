using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using NientasEssentials.Items.Tiles;

namespace NientasEssentials.Items.Consumables.GelCollectionC
{
	public class GelCandy4 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("75% Gel Candy");
			Tooltip.SetDefault("Compressed 75%");
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 100;
			item.useAnimation = 20;
			item.useStyle = 2;
			item.maxStack = 99;
			item.healLife = 240;
			item.value = 300;
			item.rare = 7;
			item.UseSound = SoundID.Item3;
			item.autoReuse = false;
			item.potion = true;
		}

        public override void OnConsumeItem(Player player)
        {
            base.OnConsumeItem(player);
			player.AddBuff(BuffID.Lifeforce, 20);
			player.doubleJumpFart = true;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 1);
			recipe.AddIngredient(mod.ItemType("GelCandy3"), 2);
			recipe.AddTile(ModContent.TileType<BlueWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}