using NientasEssentials.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace NientasEssentials.Items.Armor.CrackiumArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class CrackiumHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crackium Helmet");
			Tooltip.SetDefault("Still too powerful for your own good.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 20000;
			item.rare = ItemRarityID.LightPurple;
			item.defense = 8;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<CrackiumChestplate>() && legs.type == ModContent.ItemType<CrackiumLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Super Speed, 2x melee damage, no fall damage...";
			player.allDamage -= 0.2f;
			player.moveSpeed = +1.5f;
			player.noFallDmg = true;
			player.meleeDamageMult = 2f;
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