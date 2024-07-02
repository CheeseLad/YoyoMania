using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class IronYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Iron Yoyo");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("IronYoyoProjectile").Type;
		base.Item.damage = 16;
		base.Item.knockBack = 2.6f;
		base.Item.value = Item.sellPrice(0, 0, 5);
		base.Item.rare = 1;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(22, 5);
		recipe.AddTile(16);
		recipe.Register();
	}
}
