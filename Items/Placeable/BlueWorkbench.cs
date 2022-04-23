using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Placeable
{
	public class BlueWorkbench : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used to create most Nextras items.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 150;
			item.createTile = ModContent.TileType<Tiles.BlueWorkbench>();
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 2);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}