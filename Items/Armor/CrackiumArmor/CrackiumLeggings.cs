using NientasEssentials.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NientasEssentials.Items.Armor.CrackiumArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class CrackiumLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crackium Leggings");
			Tooltip.SetDefault("Quite powerful.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 15000;
			item.rare = ItemRarityID.LightPurple;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Crackium"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}