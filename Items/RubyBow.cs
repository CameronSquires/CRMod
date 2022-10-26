using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CRMod.Items
{
    public class RubyBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Ruby Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A Bow of Pure Ruby.");
        }

        public override void SetDefaults()
        {
            Item.damage = 24;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 16;
            Item.height = 32;
            Item.useTime = 28;
            Item.useAnimation = 28;
            Item.knockBack = 2;
            Item.value = Item.sellPrice(silver: 60);
            Item.rare = 2;
            Item.autoReuse = true;
            Item.maxStack = 1;
            Item.useStyle = 5;
            Item.UseSound = SoundID.Item5;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
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