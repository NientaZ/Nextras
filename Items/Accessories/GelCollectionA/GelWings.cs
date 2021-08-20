using NientasEssentials.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NientasEssentials.Items.Accessories.GelCollectionA
{
	[AutoloadEquip(EquipType.Wings)]
	public class GelWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Cheap, but expensive!");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 100;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 32;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 3f;
			acceleration *= 2.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("GravityTalisman"), 1);
			recipe.AddIngredient(mod.ItemType("MegaGel"), 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}