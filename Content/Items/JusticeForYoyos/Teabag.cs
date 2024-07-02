using YoyoMania.Content.Projectiles.JusticeForYoyos;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.JusticeForYoyos;
{
	public class Teabag : ModItem
	{
		public override void SetStaticDefaults() {
			// Tooltip.SetDefault("Get a lot of herbs");
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Cobweb, 10);
			recipe.AddTile(TileID.Loom);
			recipe.Register();
		}
	}
}
