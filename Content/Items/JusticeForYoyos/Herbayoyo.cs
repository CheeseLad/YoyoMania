using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using YoyoMania.Content.Projectiles.JusticeForYoyos;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoyoMania.Content.Items.JusticeForYoyos;

{
	public class Herbayoyo : ModItem
	{
		public override void SetStaticDefaults() {
			// Tooltip.SetDefault("Went from herbs to tea\n Shoots 6 yoyos, Ton of debuffs, Extremely agile\n -Herbatka");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[Item.type] = true;
			ItemID.Sets.GamepadExtraRange[Item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[Item.type] = true;
		}

		public override void SetDefaults() {
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.width = 24;
			Item.height = 24;
			Item.useAnimation = 8;
			Item.useTime = 8;
			Item.shootSpeed = 40f;
			Item.knockBack = 12f;
			Item.damage = 194;
			Item.rare = ItemRarityID.Lime;

			Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			Item.channel = true;
			Item.noMelee = true;
			Item.noUseGraphic = true;

			Item.UseSound = SoundID.Item1;
			Item.value = Item.sellPrice(platinum: 1);
			Item.shoot = ModContent.ProjectileType<HerbayoyoProjectile>();
		}

		// Make sure that your item can even receive these prefixes (check the vanilla wiki on prefixes)
		// These are the ones that reduce damage of a melee weapon
		private static readonly int[] unwantedPrefixes = new int[] { PrefixID.Terrible, PrefixID.Dull, PrefixID.Shameful, PrefixID.Annoying, PrefixID.Broken, PrefixID.Damaged, PrefixID.Shoddy};

		public override bool AllowPrefix(int pre) {
			// return false to make the game reroll the prefix

			// DON'T DO THIS BY ITSELF:
			// return false;
			// This will get the game stuck because it will try to reroll every time. Instead, make it have a chance to return true

			if (Array.IndexOf(unwantedPrefixes, pre) > -1) {
				// IndexOf returns a positive index of the element you search for. If not found, it's less than 0. Here check the opposite
				// Rolled a prefix we don't want, reroll
				return false;
			}
			// Don't reroll
			return true;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<MegaTeabag>());
			recipe.AddIngredient(ItemID.LunarBar, 7);
			recipe.AddIngredient(ItemID.WoodYoyo);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)

     		   {

        		    float spread = 0.1f * 0.0174f;
        		    float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
        		    double startAngle = Math.Atan2(speedX, speedY) - spread / 2;
         		   double deltaAngle = spread / 40f;
         		   double offsetAngle;
          		  int i;
         		   for (i = 0; i < 5; i++)
          		  {
           		     offsetAngle = startAngle + deltaAngle * i;
            		    Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed * (float)Math.Sin(offsetAngle), baseSpeed * (float)Math.Cos(offsetAngle), Mod.Find<ModProjectile>("HerbayoyoProjectile").Type, damage, knockBack, Item.playerIndexTheItemIsReservedFor);
           		 }
         		   return false;
		}
	}
}
