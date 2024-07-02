using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class GrandHarvest : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Grand Harvest");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("GrandHarvestProjectile").Type;
		base.Item.damage = 38;
		base.Item.knockBack = 4.3f;
		base.Item.value = Item.sellPrice(0, 0, 15);
		base.Item.rare = 2;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(1257, 5);
		recipe.AddTile(16);
		recipe.Register();
	}
}
