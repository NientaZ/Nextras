using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Accessories.Talismans
{
	public class BreathingTalisman : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Breathing Talisman");
			Tooltip.SetDefault("You can finally breathe true air!");
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
			player.lavaImmune = true;
			player.breathMax = 200;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 15);
			recipe.AddIngredient(ItemID.Acorn, 10);
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}