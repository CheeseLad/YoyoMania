using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Projectiles.SoManyYoyos;

public class CaptainAmericasYoyoProjectile : ModProjectile
{
	public override void SetStaticDefaults()
	{
		ProjectileID.Sets.YoyosLifeTimeMultiplier[base.Projectile.type] = -1f;
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

	public virtual void OnHitNPC(NPC n, int damage, float knockback, bool crit)
	{
		_ = Main.player[base.Projectile.owner];
		if (Main.rand.Next(10) == 0)
		{
			n.AddBuff(36, 360);
		}
	}
}
