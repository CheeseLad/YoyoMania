using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class Mirasoma : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Mirasoma");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("MirasomaProjectile").Type;
		base.Item.damage = 19;
		base.Item.knockBack = 2.6f;
		base.Item.value = Item.sellPrice(0, 2);
		base.Item.rare = 2;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(155);
		recipe.AddIngredient(3278);
		recipe.AddTile(16);
		recipe.Register();
	}
}
