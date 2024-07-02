using YoyoMania.Content.Projectiles.SoManyYoyos;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.SoManyYoyos;

public class Stratum : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Stratum");
		// base.Tooltip.SetDefault("A yoyo made from the deepest parts of the terrarian stratum");
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
		base.Item.knockBack = 5f;
		base.Item.damage = 30;
		base.Item.rare = 1;
		base.Item.DamageType = DamageClass.Melee;
		base.Item.channel = true;
		base.Item.noMelee = true;
		base.Item.noUseGraphic = true;
		base.Item.UseSound = SoundID.Item1;
		base.Item.value = Item.sellPrice(0, 0, 1);
		base.Item.shoot = ModContent.ProjectileType<StratumProjectile>();
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(2, 500);
		recipe.AddIngredient(3, 500);
		recipe.AddIngredient(699, 50);
		recipe.AddIngredient(11, 50);
		recipe.AddIngredient(14, 50);
		recipe.AddIngredient(13, 50);
		recipe.Register();
	}
}
