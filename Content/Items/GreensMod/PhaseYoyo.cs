using YoyoMania.Content.Projectiles.GreensMod;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.GreensMod;

public class PhaseYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Jedi's Toy");
		// base.Tooltip.SetDefault("May the force be with you");
		ItemID.Sets.Yoyo[base.Item.type] = true;
	}

	public override void SetDefaults()
	{
		base.Item.damage = 42;
		base.Item.DamageType = DamageClass.Generic;
		base.Item.width = 40;
		base.Item.height = 40;
		base.Item.useTime = 32;
		base.Item.useAnimation = 32;
		base.Item.useStyle = 5;
		base.Item.knockBack = 6f;
		base.Item.value = 40000;
		base.Item.rare = 5;
		base.Item.UseSound = SoundID.Item1;
		base.Item.autoReuse = true;
		base.Item.noUseGraphic = true;
		base.Item.channel = true;
		base.Item.shoot = ModContent.ProjectileType<PhaseYoyoProjectile>();
		base.Item.shootSpeed = 4f;
		base.Item.noMelee = true;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(200);
		recipe.AddIngredient(3281);
		recipe.AddIngredient(502, 15);
		recipe.AddIngredient(549, 10);
		recipe.AddTile(18);
		recipe.Register();
	}
}
