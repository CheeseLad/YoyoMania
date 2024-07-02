using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class Spazmatism : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Spazmatism");
		// base.Tooltip.SetDefault("Inflicts cursed flames");
	}

	public override void SetDefaults()
	{
		base.Item.useStyle = 5;
		base.Item.width = 32;
		base.Item.height = 32;
		base.Item.noUseGraphic = true;
		base.Item.DamageType = DamageClass.Melee;
		base.Item.channel = true;
		base.Item.UseSound = SoundID.Item1;
		base.Item.useAnimation = 25;
		base.Item.useTime = 25;
		base.Item.shoot = base.Mod.Find<ModProjectile>("SpazmatismProjectile").Type;
		base.Item.damage = 143;
		base.Item.knockBack = 3.4f;
		base.Item.value = Item.sellPrice(0, 15);
		base.Item.rare = 8;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(3292);
		recipe.AddIngredient(521, 30);
		recipe.AddIngredient(544);
		recipe.AddIngredient(522, 15);
		recipe.AddTile(133);
		recipe.Register();
	}
}
