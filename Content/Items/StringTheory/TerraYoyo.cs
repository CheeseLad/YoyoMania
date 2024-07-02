using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class TerraYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Terra Yoyo");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("TerraYoyoProjectile").Type;
		base.Item.damage = 84;
		base.Item.knockBack = 6f;
		base.Item.value = Item.sellPrice(0, 17);
		base.Item.rare = 8;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ModContent.ItemType<TrueLunarThrow>());
		recipe.AddIngredient(ModContent.ItemType<TrueHallowedYoyo>());
		recipe.AddIngredient(ModContent.ItemType<BrokenHeroYoyo>());
		recipe.AddTile(134);
		recipe.Register();
	}
}
