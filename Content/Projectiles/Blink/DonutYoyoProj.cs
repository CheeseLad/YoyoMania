using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Projectiles.Blink;

public class DonutYoyoProj : ModProjectile
{
	public override void SetStaticDefaults()
	{
		ProjectileID.Sets.YoyosLifeTimeMultiplier[base.Projectile.type] = 8f;
		ProjectileID.Sets.YoyosMaximumRange[base.Projectile.type] = 500f;
		ProjectileID.Sets.YoyosTopSpeed[base.Projectile.type] = 48f;
	}

	public override void SetDefaults()
	{
		base.Projectile.width = 16;
		base.Projectile.height = 16;
		base.Projectile.friendly = true;
		base.Projectile.tileCollide = true;
		base.Projectile.ignoreWater = false;
		base.Projectile.DamageType = DamageClass.Melee;
		base.Projectile.aiStyle = 99;
		base.Projectile.penetrate = -1;
	}
}
