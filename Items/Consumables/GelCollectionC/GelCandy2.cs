using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Consumables.GelCollectionC
{
	public class GelCandy2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("25% Gel Candy");
			Tooltip.SetDefault("Compressed 25%");
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 175;
			item.useAnimation = 20;
			item.useStyle = 2;
			item.maxStack = 99;
			item.healLife = 60;
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
			recipe.AddIngredient(ItemID.Gel, 10);
			recipe.AddIngredient(mod.ItemType("GelCandy"), 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}