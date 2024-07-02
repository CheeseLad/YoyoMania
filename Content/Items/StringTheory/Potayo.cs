using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.StringTheory;

public class Potayo : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Potayo");
		// base.Tooltip.SetDefault("- Developer Item -");
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
		base.Item.shoot = base.Mod.Find<ModProjectile>("PotayoProjectile").Type;
		base.Item.damage = 9999999;
		base.Item.knockBack = 5f;
		base.Item.value = Item.sellPrice(2);
		base.Item.rare = 11;
	}

	public override void AddRecipes()
	{
	}
}
