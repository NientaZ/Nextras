using NientasEssentials.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using NientasEssentials.Items.Tiles;

namespace NientasEssentials.Items.Armor.GelArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class GelHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Long awaited Gel Helmet!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 1;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<GelChestplate>() && legs.type == ModContent.ItemType<GelLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Auto Jump";
			player.allDamage -= 0.2f;
			player.autoJump = true;
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