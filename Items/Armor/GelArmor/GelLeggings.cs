using NientasEssentials.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using NientasEssentials.Items.Tiles;

namespace NientasEssentials.Items.Armor.GelArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class GelLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Long awaited Gel leggings!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 6);
			recipe.AddTile(ModContent.TileType<BlueWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}