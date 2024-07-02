using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Projectiles.SoManyYoyos;

public class BlizzardProjectile : ModProjectile
{
	public override void SetStaticDefaults()
	{
		ProjectileID.Sets.YoyosLifeTimeMultiplier[base.Projectile.type] = 5f;
		ProjectileID.Sets.YoyosMaximumRange[base.Projectile.type] = 230f;
		ProjectileID.Sets.YoyosTopSpeed[base.Projectile.type] = 11f;
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
			n.AddBuff(44, 180);
		}
	}

	public override void PostAI()
	{
		if (Main.rand.Next(2) == 0)
		{
			Dust dust = Dust.NewDustDirect(base.Projectile.position, base.Projectile.width, base.Projectile.height, 16);
			dust.noGravity = true;
			dust.scale = 1.6f;
		}
	}
}
