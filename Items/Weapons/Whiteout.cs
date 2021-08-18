using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Weapons
{
	public class Whiteout : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Whiteout");
			Tooltip.SetDefault("???");
		}

		public override void SetDefaults() 
		{
			item.damage = 375;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 150;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 75);
			recipe.AddIngredient(ItemID.SilverDye, 3);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}