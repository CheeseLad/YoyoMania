using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class PalmWoodYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Palm Wood Yoyo");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("PalmWoodYoyoProjectile").Type;
		base.Item.damage = 12;
		base.Item.knockBack = 2.5f;
		base.Item.value = Item.sellPrice(0, 0, 2);
		base.Item.rare = 0;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(150, 20);
		recipe.AddIngredient(2504, 10);
		recipe.AddTile(18);
		recipe.Register();
	}
}
