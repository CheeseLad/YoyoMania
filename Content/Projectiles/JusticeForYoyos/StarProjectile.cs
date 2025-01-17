using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Projectiles.JusticeForYoyos;
{
	public class StarProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Star");
		}

		public override void SetDefaults()
		{
			Projectile.arrow = false;
			Projectile.width = 7;
			Projectile.height = 6;
			Projectile.aiStyle = 1;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.penetrate = 3;
			Projectile.scale = 2f;
			AIType = ProjectileID.JestersArrow;
		}
		public override void PostAI() {
			if (Main.rand.NextBool()) {
				Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, 272);
				dust.noGravity = false;
				dust.scale = 1.1f;
			}
		}
	}
}