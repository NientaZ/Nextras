using NientasEssentials.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using NientasEssentials.Items.Tiles;

namespace NientasEssentials.Items.Weapons.Ammo
{
	public class CrackiumPellet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Broken-down Crackum");
		}
		public override void SetDefaults()
		{
			item.damage = 24;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = ItemRarityID.LightPurple;
			item.shoot = ModContent.ProjectileType<Projectiles.CrackiumPellet>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 4f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}
		// Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
		public override void OnConsumeAmmo(Player player)
		{
			if (Main.rand.NextBool(5))
			{
				player.AddBuff(BuffID.Poisoned, 300);
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Crackium"), 1);
			recipe.AddTile(ModContent.TileType<BlueWorkbench>());
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}
	}
}