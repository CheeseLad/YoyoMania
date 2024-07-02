using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class Widow : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Widow");
		// base.Tooltip.SetDefault("Covers your enemies in a painful poison");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("WidowProjectile").Type;
		base.Item.damage = 61;
		base.Item.knockBack = 3.4f;
		base.Item.value = Item.sellPrice(0, 0, 93);
		base.Item.rare = 4;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(2607, 15);
		recipe.AddTile(133);
		recipe.Register();
	}
}
