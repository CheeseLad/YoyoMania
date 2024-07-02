using YoyoMania.Content.Projectiles.SoManyYoyos;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.SoManyYoyos;

public class Combustion : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Combustion");
		// base.Tooltip.SetDefault("A firey combustion from the pits of hell");
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
		base.Item.shootSpeed = 25f;
		base.Item.knockBack = 4.5f;
		base.Item.damage = 35;
		base.Item.rare = 10;
		base.Item.DamageType = DamageClass.Melee;
		base.Item.channel = true;
		base.Item.noMelee = true;
		base.Item.noUseGraphic = true;
		base.Item.UseSound = SoundID.Item1;
		base.Item.value = Item.sellPrice(0, 0, 1);
		base.Item.shoot = ModContent.ProjectileType<CombustionProjectile>();
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(175, 20);
		recipe.AddIngredient(168, 10);
		recipe.Register();
	}
}
