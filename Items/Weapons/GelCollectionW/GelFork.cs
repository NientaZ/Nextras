using Terraria.ID;
using Terraria.ModLoader;
using NientasEssentials.Items.Tiles;

namespace NientasEssentials.Items.Weapons.GelCollectionW
{
	public class GelFork : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Gel Fork");
			Tooltip.SetDefault("Made with Kitchen Utensils!");
		}

		public override void SetDefaults() 
		{
			item.damage = 19;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 150;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 7);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.SilverBar, 1);
			recipe.AddTile(ModContent.TileType<BlueWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}