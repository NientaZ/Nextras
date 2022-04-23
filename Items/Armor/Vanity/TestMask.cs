using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace NientasEssentials.Items.Armor.Vanity
{
	[AutoloadEquip(EquipType.Head)]
	public class TestMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Laughable Mask");
			Tooltip.SetDefault("Don't laugh too hard");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.rare = ItemRarityID.LightPurple;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("BlueSilk"), 3);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}