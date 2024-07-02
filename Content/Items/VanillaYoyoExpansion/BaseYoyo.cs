using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using YoyoMania.Content.Projectiles.VanillaYoyoExpansion;

namespace YoyoMania.Content.Items.VanillaYoyoExpansion;

public class BaseYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Yoyo Base");
	}

	public override void SetDefaults()
	{
		base.Item.damage = 10;
		base.Item.DamageType = DamageClass.Melee;
		base.Item.width = 24;
		base.Item.height = 24;
		base.Item.useTime = 25;
		base.Item.useAnimation = 25;
		base.Item.useStyle = 5;
		base.Item.knockBack = 2.5f;
		base.Item.value = Item.sellPrice(0, 0, 1);
		base.Item.rare = 2;
		base.Item.UseSound = SoundID.Item1;
		base.Item.channel = true;
		base.Item.noMelee = true;
		base.Item.noUseGraphic = true;
		base.Item.shoot = ModContent.ProjectileType<BaseYoyoProjectile>();
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(2, 10);
		recipe.AddTile(18);
		recipe.Register();
	}
}
