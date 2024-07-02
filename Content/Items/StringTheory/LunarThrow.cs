using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class LunarThrow : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Lunar Throw");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("LunarThrowProjectile").Type;
		base.Item.damage = 37;
		base.Item.knockBack = 4.5f;
		base.Item.value = Item.sellPrice(0, 4);
		base.Item.rare = 3;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(ModContent.ItemType<Heater>());
		recipe.AddIngredient(ModContent.ItemType<Mirasoma>());
		recipe.AddIngredient(ModContent.ItemType<YoyoOfGrass>());
		recipe.AddIngredient(ModContent.ItemType<DarkStar>());
		recipe.AddTile(26);
		recipe.Register();
	}
}
