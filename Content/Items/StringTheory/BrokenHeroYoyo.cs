using Terraria;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class BrokenHeroYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Broken Hero Yoyo");
	}

	public override void SetDefaults()
	{
		base.Item.value = Item.sellPrice(0, 1);
		base.Item.rare = 8;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(1570);
		recipe.AddIngredient(3278);
		recipe.AddTile(134);
		recipe.Register();
	}
}
