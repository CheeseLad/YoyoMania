using YoyoMania.Content.Projectiles.JusticeForYoyos;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.JusticeForYoyos;

{
	public class MegaTeabag : ModItem
	{
		public override void SetStaticDefaults() {
			// Tooltip.SetDefault("You actually got a lot of herbs!");
		}
		public override void SetDefaults() {
			Item.rare = ItemRarityID.LightRed;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Teabag>());
			recipe.AddIngredient(ItemID.Blinkroot);
			recipe.AddIngredient(ItemID.Daybloom);
			recipe.AddIngredient(ItemID.Deathweed);
			recipe.AddIngredient(ItemID.Fireblossom);
			recipe.AddIngredient(ItemID.Moonglow);
			recipe.AddIngredient(ItemID.Shiverthorn);
			recipe.AddIngredient(ItemID.Waterleaf);
			recipe.Register();
		}
	}
}
