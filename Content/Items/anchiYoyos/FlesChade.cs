using YoyoMania.Content.Projectiles.anchiYoyos;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.anchiYoyos;

public class FlesChade : ModItem
{
	public override void SetStaticDefaults()
	{
		//DisplayName.SetDefault("FlesChade");
		ItemID.Sets.Yoyo[Item.type] = true;
		ItemID.Sets.GamepadExtraRange[Item.type] = 15;
		ItemID.Sets.GamepadSmartQuickReach[Item.type] = true;
	}

	public override void SetDefaults()
	{
		Item.useStyle = 4;
		Item.width = 30;
		Item.height = 26;
		Item.useAnimation = 25;
		Item.useTime = 25;
		Item.shootSpeed = 16f;
		Item.knockBack = 3f;
		Item.damage = 31;
		Item.rare = 3;
		Item.DamageType = DamageClass.Melee;
		Item.channel = true;
		Item.noMelee = true;
		Item.noUseGraphic = true;
		Item.UseSound = SoundID.Item1;
		Item.value = Item.sellPrice(0, 3, 50);
		Item.shoot = ModContent.ProjectileType<FlesChadeProjectile>();
	}

	public virtual void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
	{
		target.AddBuff(24, 240);
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(3282);
		recipe.AddIngredient(3280);
		recipe.AddIngredient(1257, 6);
		recipe.AddIngredient(175, 6);
		recipe.AddIngredient(173, 12);
		recipe.AddTile(16);
		recipe.Register();
	}
}
