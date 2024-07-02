using YoyoMania.Content.Projectiles.SoManyYoyos;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.SoManyYoyos;

public class CaptainAmericasYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Captain America's Yoyo");
		// base.Tooltip.SetDefault("Captain America's Shield made into a yoyo");
		ItemID.Sets.Yoyo[base.Item.type] = true;
		ItemID.Sets.GamepadExtraRange[base.Item.type] = 15;
		ItemID.Sets.GamepadSmartQuickReach[base.Item.type] = true;
	}

	public override void SetDefaults()
	{
		base.Item.useStyle = 5;
		base.Item.width = 24;
		base.Item.height = 24;
		base.Item.useAnimation = 25;
		base.Item.useTime = 25;
		base.Item.shootSpeed = 16f;
		base.Item.knockBack = 3.5f;
		base.Item.damage = 175;
		base.Item.rare = -12;
		base.Item.DamageType = DamageClass.Melee;
		base.Item.channel = true;
		base.Item.noMelee = true;
		base.Item.noUseGraphic = true;
		base.Item.UseSound = SoundID.Item1;
		base.Item.value = Item.sellPrice(0, 0, 1);
		base.Item.shoot = ModContent.ProjectileType<CaptainAmericasYoyoProjectile>();
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(391, 15);
		recipe.AddIngredient(381, 15);
		recipe.AddIngredient(3473);
		recipe.AddIngredient(575, 10);
		recipe.Register();
	}
}
