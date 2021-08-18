using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Consumables.GelCollectionC
{
	public class GelCandy5 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("100% Gel Candy");
			Tooltip.SetDefault("Compressed 100%");
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 50;
			item.useAnimation = 20;
			item.useStyle = 2;
			item.maxStack = 99;
			item.healLife = 500;
			item.value = 300;
			item.rare = 8;
			item.UseSound = SoundID.Item3;
			item.autoReuse = false;
			item.potion = true;
		}

        public override void OnConsumeItem(Player player)
        {
            base.OnConsumeItem(player);
			player.AddBuff(BuffID.Lifeforce, 40);
			player.doubleJumpFart = true;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 10);
			recipe.AddIngredient(mod.ItemType("GelCandy4"), 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}