using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class Midas : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Midas");
		// base.Tooltip.SetDefault("Increases money drops on kill");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("MidasProjectile").Type;
		base.Item.damage = 62;
		base.Item.knockBack = 4f;
		base.Item.value = Item.sellPrice(0, 2);
		base.Item.rare = 5;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(490);
		recipe.AddIngredient(19, 5);
		recipe.AddTile(134);
		recipe.Register();
	}
}
