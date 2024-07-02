using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class OrichalcumYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Orichalcum Yoyo");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("OrichalcumYoyoProjectile").Type;
		base.Item.damage = 54;
		base.Item.knockBack = 4f;
		base.Item.value = Item.sellPrice(0, 0, 28);
		base.Item.rare = 3;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(1191, 5);
		recipe.AddTile(134);
		recipe.Register();
	}
}
