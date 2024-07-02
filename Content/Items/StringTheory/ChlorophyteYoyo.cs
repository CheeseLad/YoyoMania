using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class ChlorophyteYoyo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Chlorophyte Yoyo");
		// base.Tooltip.SetDefault("Poisons enemies");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("ChlorophyteYoyoProjectile").Type;
		base.Item.damage = 71;
		base.Item.knockBack = 5f;
		base.Item.value = Item.sellPrice(0, 0, 54);
		base.Item.rare = 7;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(1006, 5);
		recipe.AddTile(134);
		recipe.Register();
	}
}
