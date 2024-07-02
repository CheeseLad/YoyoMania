using YoyoMania.Content.Projectiles.GreensMod;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.GreensMod;

public class EmeraldYoyoGreensMod : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Gem Cutter");
		// base.Tooltip.SetDefault("Harder than diamonds");
		ItemID.Sets.Yoyo[base.Item.type] = true;
	}

	public override void SetDefaults()
	{
		base.Item.damage = 23;
		base.Item.DamageType = DamageClass.Generic;
		base.Item.width = 40;
		base.Item.height = 40;
		base.Item.useTime = 32;
		base.Item.useAnimation = 32;
		base.Item.useStyle = 5;
		base.Item.knockBack = 4f;
		base.Item.value = 40000;
		base.Item.rare = 3;
		base.Item.UseSound = SoundID.Item1;
		base.Item.autoReuse = true;
		base.Item.noUseGraphic = true;
		base.Item.channel = true;
		base.Item.shoot = ModContent.ProjectileType<EmeraldYoyoGreensModProjectile>();
		base.Item.shootSpeed = 6f;
		base.Item.noMelee = true;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(3281);
		recipe.AddIngredient(179, 15);
		recipe.AddTile(18);
		recipe.Register();
	}
}
