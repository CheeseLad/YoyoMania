using YoyoMania.Content.Projectiles.SoManyYoyos;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.SoManyYoyos;

public class H2O : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("H2O");
		// base.Tooltip.SetDefault("A liquid yoyo made from hydrogen and oxygen");
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
		base.Item.knockBack = 2.5f;
		base.Item.damage = 125;
		base.Item.rare = 1;
		base.Item.DamageType = DamageClass.Melee;
		base.Item.channel = true;
		base.Item.noMelee = true;
		base.Item.noUseGraphic = true;
		base.Item.UseSound = SoundID.Item1;
		base.Item.value = Item.sellPrice(0, 0, 1);
		base.Item.shoot = ModContent.ProjectileType<H2OProjectile>();
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(2611);
		recipe.AddIngredient(150, 20);
		recipe.AddIngredient(1198, 13);
		recipe.Register();
	}
}
