using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class NokNokJoek : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Nok Nok Joek");
		// base.Tooltip.SetDefault("➤➤➤➤");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("NokNokJoekProjectile").Type;
		base.Item.damage = 24;
		base.Item.knockBack = 50f;
		base.Item.value = Item.sellPrice(0, 1);
		base.Item.rare = 4;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(548, 15);
		recipe.AddTile(134);
		recipe.Register();
	}
}
