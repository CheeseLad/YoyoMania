using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Projectiles.anchiYoyos;

public class FlesChadeProjectile : ModProjectile
{
	public override void SetStaticDefaults()
	{
		ProjectileID.Sets.YoyosLifeTimeMultiplier[base.Projectile.type] = 12f;
		ProjectileID.Sets.YoyosMaximumRange[base.Projectile.type] = 350f;
		ProjectileID.Sets.YoyosTopSpeed[base.Projectile.type] = 12f;
	}

	public override void SetDefaults()
	{
		base.Projectile.extraUpdates = 0;
		base.Projectile.width = 16;
		base.Projectile.height = 16;
		base.Projectile.aiStyle = 99;
		base.Projectile.friendly = true;
		base.Projectile.penetrate = -1;
		base.Projectile.DamageType = DamageClass.Melee;
		base.Projectile.scale = 1f;
	}
}
