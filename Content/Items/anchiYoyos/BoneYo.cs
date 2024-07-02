using YoyoMania.Content.Projectiles.anchiYoyos;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.anchiYoyos;

public class BoneYo : ModItem
{
	public override void SetStaticDefaults()
	{
		ItemID.Sets.Yoyo[base.Item.type] = true;
		ItemID.Sets.GamepadExtraRange[base.Item.type] = 15;
		ItemID.Sets.GamepadSmartQuickReach[base.Item.type] = true;
	}

	public override void SetDefaults()
	{
		base.Item.useStyle = 4;
		base.Item.width = 30;
		base.Item.height = 26;
		base.Item.useAnimation = 25;
		base.Item.useTime = 25;
		base.Item.shootSpeed = 16f;
		base.Item.knockBack = 2.5f;
		base.Item.damage = 24;
		base.Item.rare = 3;
		base.Item.DamageType = DamageClass.Melee;
		base.Item.channel = true;
		base.Item.noMelee = true;
		base.Item.noUseGraphic = true;
		base.Item.UseSound = SoundID.Item1;
		base.Item.value = Item.sellPrice(0, 2);
		base.Item.shoot = ModContent.ProjectileType<BoneYoProjectile>();
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(154, 50);
		recipe.AddIngredient(3285);
		recipe.AddIngredient(150, 30);
		recipe.AddTile(16);
		recipe.Register();
	}
}
