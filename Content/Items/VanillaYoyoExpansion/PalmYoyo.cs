using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using YoyoMania.Content.Projectiles.VanillaYoyoExpansion;

namespace YoyoMania.Content.Items.VanillaYoyoExpansion;

public class PalmYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Palm Wood Yoyo");
	}

	public override void SetDefaults()
	{
		base.Item.damage = 9;
		base.Item.DamageType = DamageClass.Melee;
		base.Item.width = 24;
		base.Item.height = 24;
		base.Item.useTime = 25;
		base.Item.useAnimation = 25;
		base.Item.useStyle = 5;
		base.Item.knockBack = 2.5f;
		base.Item.value = Item.sellPrice(0, 0, 1);
		base.Item.rare = 0;
		base.Item.UseSound = SoundID.Item1;
		base.Item.channel = true;
		base.Item.noMelee = true;
		base.Item.noUseGraphic = true;
		base.Item.shoot = ModContent.ProjectileType<PalmYoyoProjectile>();
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(2504, 10);
		recipe.AddIngredient(150, 20);
		recipe.AddTile(18);
		recipe.Register();
	}
}
