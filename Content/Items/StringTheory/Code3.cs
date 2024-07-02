using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class Code3 : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Code 3");
		// base.Tooltip.SetDefault("cant find a copy and paste of the onedrop logo lol");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("Code3Projectile").Type;
		base.Item.damage = 96;
		base.Item.knockBack = 6f;
		base.Item.value = Item.sellPrice(0, 10);
		base.Item.rare = 10;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(3284);
		recipe.AddIngredient(3262);
		recipe.AddIngredient(3544, 5);
		recipe.AddTile(133);
		recipe.Register();
	}
}
