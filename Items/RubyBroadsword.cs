using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CRMod.Items
{
	public class RubyBroadsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("RubyBroadsword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A Blade of Pure Ruby.");
		}

		public override void SetDefaults()
		{
			Item.damage = 24;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = Item.sellPrice(silver: 60);
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddIngredient(ItemID.IronBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.Ruby, 10);
            recipe2.AddIngredient(ItemID.LeadBar, 8);
            recipe2.AddTile(TileID.Anvils);
            recipe2.Register();
        }
	}
}