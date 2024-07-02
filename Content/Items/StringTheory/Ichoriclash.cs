using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class Ichoriclash : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Ichoriclash");
		// base.Tooltip.SetDefault("Inflicts ichor in targets");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("IchoriclashProjectile").Type;
		base.Item.damage = 53;
		base.Item.knockBack = 3.4f;
		base.Item.value = Item.sellPrice(0, 1);
		base.Item.value = Item.sellPrice(0, 0, 50);
		base.Item.rare = 5;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(1257, 5);
		recipe.AddIngredient(1332, 20);
		recipe.AddTile(134);
		recipe.Register();
	}
}
