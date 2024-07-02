using YoyoMania.Content.Projectiles.Blink;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.Blink;

public class DonutYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Donut Yoyo");
		// base.Tooltip.SetDefault("Yoyo, made of donut.");
	}

	public override void SetDefaults()
	{
		base.Item.damage = 129;
		base.Item.DamageType = DamageClass.Melee;
		base.Item.width = 120;
		base.Item.height = 120;
		base.Item.useTime = 84;
		base.Item.useAnimation = 24;
		base.Item.useStyle = 5;
		base.Item.knockBack = 1f;
		base.Item.value = 1000;
		base.Item.rare = 5;
		base.Item.UseSound = SoundID.Item43;
		base.Item.autoReuse = true;
		base.Item.noUseGraphic = true;
		base.Item.noMelee = true;
		base.Item.channel = true;
		base.Item.shoot = ModContent.ProjectileType<DonutYoyoProj>();
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(225, 3);
		recipe.AddIngredient(170, 3);
		recipe.AddIngredient(22, 3);
		recipe.AddTile(17);
		recipe.Register();
	}
}
