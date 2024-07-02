using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class YoyoOfGrass : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Yoyo Of Grass");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("YoyoOfGrassProjectile").Type;
		base.Item.damage = 25;
		base.Item.knockBack = 3f;
		base.Item.value = Item.sellPrice(0, 0, 50);
		base.Item.rare = 3;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(209, 10);
		recipe.AddIngredient(331, 13);
		recipe.AddIngredient(210, 5);
		recipe.AddTile(16);
		recipe.Register();
	}
}
