using Terraria;
using Terraria.ModLoader;

namespace YoyoMania.Content.Accessories.anchiYoyos;

public class BoneYoGlove : ModItem
{
	public override void SetStaticDefaults()
	{
		// base.DisplayName.SetDefault("BoneYo Glove");
		// base.Tooltip.SetDefault("Allows the use of two yoyos at once\nShoots crossbones at enemies while you are attacking");
	}

	public override void SetDefaults()
	{
		base.Item.width = 20;
		base.Item.height = 22;
		base.Item.value = Item.sellPrice(0, 12);
		base.Item.rare = -12;
		base.Item.accessory = true;
	}

	public override void UpdateAccessory(Player player, bool hideVisual)
	{
		player.boneGloveItem = base.Item;
		player.yoyoGlove = true;
	}

	public override void AddRecipes()
	{
		Recipe recipe = CreateRecipe();
		recipe.AddIngredient(3245);
		recipe.AddIngredient(3334);
		recipe.AddTile(114);
		recipe.Register();
	}
}
