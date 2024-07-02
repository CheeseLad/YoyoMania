using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class TrueLunarThrow : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("True Lunar Throw");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("TrueLunarThrowProjectile").Type;
		base.Item.damage = 67;
		base.Item.knockBack = 4.5f;
		base.Item.value = Item.sellPrice(0, 8);
		base.Item.rare = 8;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ModContent.ItemType<LunarThrow>());
		recipe.AddIngredient(549, 15);
		recipe.AddIngredient(548, 15);
		recipe.AddIngredient(547, 15);
		recipe.AddTile(134);
		recipe.Register();
	}
}
