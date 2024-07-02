using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Projectiles.GreensMod;

public class PhaseYoyoProjectile : ModProjectile
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("Jedi's Toy");
		ProjectileID.Sets.YoyosLifeTimeMultiplier[base.Projectile.type] = 25f;
		ProjectileID.Sets.YoyosMaximumRange[base.Projectile.type] = 300f;
		ProjectileID.Sets.YoyosTopSpeed[base.Projectile.type] = 30f;
	}

	public override void SetDefaults()
	{
		base.Projectile.DamageType = DamageClass.Melee;
		base.Projectile.width = 16;
		base.Projectile.height = 16;
		base.Projectile.aiStyle = 99;
		base.Projectile.friendly = true;
		base.Projectile.hostile = false;
		base.Projectile.penetrate = -1;
	}
}
