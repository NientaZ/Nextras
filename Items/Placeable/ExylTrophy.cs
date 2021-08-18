using NientasEssentials.Items.Tiles;
using NientasEssentials.Items.Placeable;
using Terraria.ModLoader;
using Terraria.ID;

namespace NientasEssentials.Items.Placeable
{
	public class ExylTrophy : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 500;
			item.rare = ItemRarityID.Blue;
			item.createTile = ModContent.TileType<BossTrophy>();
			item.placeStyle = 0;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 7);
			recipe.AddIngredient(ItemID.GoldBar, 2);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}