using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class CerebralTwister : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Cerebral Twister");
		// base.Tooltip.SetDefault("Has a 50% chance to inflict confusion on target");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("CerebralTwisterProjectile").Type;
		base.Item.damage = 32;
		base.Item.knockBack = 4f;
		base.Item.value = Item.sellPrice(0, 0, 80);
		base.Item.rare = 2;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(1330, 20);
		recipe.AddIngredient(1329, 5);
		recipe.AddIngredient(2887, 2);
		recipe.AddTile(16);
		recipe.Register();
	}
}
