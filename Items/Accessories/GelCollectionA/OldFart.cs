using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Accessories.GelCollectionA
{
	public class OldFart : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Old Fart");
			Tooltip.SetDefault("Respect your elders.");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 40;
			item.height = 40;
			item.value = 3000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.maxStack = 99;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statDefense += 3;
			player.accRunSpeed = 2f;
			player.maxRunSpeed = 4f;
			player.doubleJumpFart = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}