using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NientasEssentials.Items.Materials
{
	public class Crackium : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crackium");
			Tooltip.SetDefault("Crack on crack");
		}

		public override void SetDefaults()
		{
			item.material = true;
			item.maxStack = 99;
			item.width = 40;
			item.height = 40;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
		}
	}
}