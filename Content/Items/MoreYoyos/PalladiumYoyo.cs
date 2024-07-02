using MoreYoyos.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreYoyos.Items.Weapons
{
	public class PalladiumYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Palladium Yoyo");
			// Tooltip.SetDefault("A great throw!");
		}
		public override void SetDefaults()
		{
			Item.useStyle = 5;
			Item.width = 24;
			Item.height = 24;
			Item.useAnimation = 25;
			Item.useTime = 25;
			Item.shootSpeed = 16f;
			Item.knockBack = 6f;
			Item.damage = 38;
			Item.rare = 6;
			Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			Item.channel = true;
			Item.noMelee = true;
			Item.noUseGraphic = true;
			Item.value = Item.sellPrice(gold: 1);
            Item.shoot = Mod.Find<ModProjectile>("PalladiumYoyo").Type;
		}
		
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PalladiumBar, 10);
			recipe.AddIngredient(ItemID.Cobweb, 30);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}
