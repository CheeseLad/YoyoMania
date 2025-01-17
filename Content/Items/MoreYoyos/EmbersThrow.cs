﻿using MoreYoyos.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreYoyos.Items.Weapons
{
	public class EmbersThrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ember's Throw");
			// Tooltip.SetDefault("Great for impersonating devs!");
		}
		public override void SetDefaults()
		{
			Item.useStyle = 5;
			Item.width = 24;
			Item.height = 24;
			Item.useAnimation = 25;
			Item.useTime = 25;
			Item.shootSpeed = 16f;
			Item.knockBack = 7f;
			Item.damage = 68;
			Item.rare = 9;
			Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			Item.channel = true;
			Item.noMelee = true;
			Item.noUseGraphic = true;
			Item.value = Item.sellPrice(gold: 2);
            Item.shoot = Mod.Find<ModProjectile>("EmbersThrow").Type;
		}
	}
}
