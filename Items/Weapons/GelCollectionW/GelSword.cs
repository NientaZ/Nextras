using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Weapons.GelCollectionW
{
	public class GelSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Gel Sword");
			Tooltip.SetDefault("For all of your basic gel-slicing needs!");
		}

		public override void SetDefaults() 
		{
			item.damage = 8;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 150;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 30);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.WoodenSword, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}