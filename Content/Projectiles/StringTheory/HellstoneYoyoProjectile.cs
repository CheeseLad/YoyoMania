using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Projectiles.StringTheory;

public class HellstoneYoyoProjectile : ModProjectile
{
	public override void SetStaticDefaults()
	{
		ProjectileID.Sets.YoyosLifeTimeMultiplier[base.Projectile.type] = 7f;
		ProjectileID.Sets.YoyosMaximumRange[base.Projectile.type] = 250f;
		ProjectileID.Sets.YoyosTopSpeed[base.Projectile.type] = 14f;
	}

	public virtual void OnHitNPC(NPC target, int damage, float knockback, bool crit)
	{
		if (Main.rand.NextFloat() < 1f)
		{
			target.AddBuff(24, 500);
		}
	}

	public override void SetDefaults()
	{
		base.Projectile.extraUpdates = 0;
		base.Projectile.width = 16;
		base.Projectile.height = 16;
		base.Projectile.aiStyle = 99;
		base.Projectile.friendly = true;
		base.Projectile.DamageType = DamageClass.Melee;
		base.Projectile.penetrate = -1;
		base.Projectile.scale = 1f;
	}

	public override void AI()
	{
		if (base.Projectile.localAI[0] == 0f)
		{
			base.Projectile.localAI[0] = 1f;
			Player owner = Main.player[base.Projectile.owner];
			Vector2 vector = owner.RotatedRelativePoint(owner.MountedCenter, reverseRotation: true);
			float scaleFactor = 1f;
			if (owner.inventory[owner.selectedItem].shoot == base.Projectile.type)
			{
				scaleFactor = owner.inventory[owner.selectedItem].shootSpeed * base.Projectile.scale;
			}
			Vector2 vector2 = Main.MouseWorld - vector;
			vector2.Normalize();
			if (vector2.HasNaNs())
			{
				vector2 = Vector2.UnitX * owner.direction;
			}
			vector2 *= scaleFactor;
			base.Projectile.velocity = vector2;
		}
	}

	public override bool PreDraw(ref Color lightColor)
	{
		Texture2D texture = TextureAssets.Projectile[base.Projectile.type].Value;
		Vector2 origin = new Vector2((float)texture.Width * 0.5f, (float)texture.Height * 0.5f);
		for (int i = 0; i < base.Projectile.oldPos.Length; i++)
		{
			Vector2 position = base.Projectile.oldPos[i] - Main.screenPosition + origin + new Vector2(0f, base.Projectile.gfxOffY);
			Color color = base.Projectile.GetAlpha(lightColor) * ((float)(base.Projectile.oldPos.Length - i) / (float)base.Projectile.oldPos.Length);
			Main.spriteBatch.Draw(texture, position, null, color, base.Projectile.rotation, origin, base.Projectile.scale, SpriteEffects.None, 0f);
		}
		return true;
	}
}
