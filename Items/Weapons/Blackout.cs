using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Weapons
{
	public class Blackout : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blackout");
			Tooltip.SetDefault("???");
		}

		public override void SetDefaults() 
		{
			item.damage = 125;
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
			recipe.AddIngredient(ItemID.MeteoriteBar, 35);
			recipe.AddIngredient(ItemID.BlackDye, 3);
			recipe.AddIngredient(ItemID.BladeofGrass, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}