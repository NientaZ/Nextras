using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Weapons.GelCollectionW
{
	public class GelButchering : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Gel Butchering Knife");
			Tooltip.SetDefault("Made with Diamond Essence!");
		}

		public override void SetDefaults() 
		{
			item.damage = 65;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 250;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 100);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.Diamond, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}