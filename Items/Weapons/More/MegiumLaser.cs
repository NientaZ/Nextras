using NientasEssentials.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Weapons.More
{
	public class MegiumLaser : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("When two eternal forces become one...");
		}

		public override void SetDefaults()
		{
			item.damage = 70;
			item.noMelee = true;
			item.magic = true;
			item.channel = true;
			item.mana = 18;
			item.rare = ItemRarityID.LightPurple;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = ModContent.ProjectileType<Laser>();
			item.value = Item.sellPrice(gold: 1);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Megium", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}