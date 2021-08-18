using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Accessories.Talismans
{
	public class FishingTalisman : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fishing Talisman");
			Tooltip.SetDefault("People say luck doesn't exist...");
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
			player.fishingSkill = 50;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 15);
			recipe.AddIngredient(ItemID.GoldenFishingRod, 1);
			recipe.AddIngredient(ItemID.PinkJellyfish, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}