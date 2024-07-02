using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class PearlwoodYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Pearlwood Yoyo");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("PearlwoodYoyoProjectile").Type;
		base.Item.damage = 21;
		base.Item.knockBack = 2.5f;
		base.Item.value = Item.sellPrice(0, 0, 5);
		base.Item.rare = 4;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(150, 20);
		recipe.AddIngredient(621, 10);
		recipe.AddTile(18);
		recipe.Register();
	}
}
