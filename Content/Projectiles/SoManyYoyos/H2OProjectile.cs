using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Projectiles.SoManyYoyos;

public class H2OProjectile : ModProjectile
{
	public override void SetStaticDefaults()
	{
		ProjectileID.Sets.YoyosLifeTimeMultiplier[base.Projectile.type] = 12f;
		ProjectileID.Sets.YoyosMaximumRange[base.Projectile.type] = 350f;
		ProjectileID.Sets.YoyosTopSpeed[base.Projectile.type] = 15f;
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
	}

	public override void PostAI()
	{
		if (Main.rand.Next(2) == 0)
		{
			Dust dust = Dust.NewDustDirect(base.Projectile.position, base.Projectile.width, base.Projectile.height, 33);
			dust.noGravity = true;
			dust.scale = 1.6f;
		}
	}

	public override void AI()
	{
		Main.rand.Next(10);
	}
}
