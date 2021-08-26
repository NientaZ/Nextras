using NientasEssentials.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Armor.CrackiumArmor
{
	[AutoloadEquip(EquipType.Body)]
	public class CrackiumChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Crackium Chestplate");
			Tooltip.SetDefault("Too powerful for your own good.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 25000;
			item.rare = ItemRarityID.LightPurple;
			item.defense = 14;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.Slow] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Crackium"), 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}