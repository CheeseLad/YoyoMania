﻿using MoreYoyos.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreYoyos.Items.Weapons
{
	public class IronYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Iron Yoyo");
			// Tooltip.SetDefault("A great throw!");
		}
		public override void SetDefaults()
		{
			Item.useStyle = 5;
			Item.width = 24;
			Item.height = 24;
			Item.useAnimation = 25;
			Item.useTime = 25;
			Item.shootSpeed = 16f;
			Item.knockBack = 4f;
			Item.damage = 12;
			Item.rare = 2;
			Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			Item.channel = true;
			Item.noMelee = true;
			Item.noUseGraphic = true;
			Item.value = Item.sellPrice(silver: 60);
            Item.shoot = Mod.Find<ModProjectile>("IronYoyo").Type;
		}
		
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.Cobweb, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
