﻿using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class StorageUnitBlueChlorophyte : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Chlorophyte Storage Unit");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Russian), "Синяя Хлорофитовая Ячейка Хранилища");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Polish), "Jednostka magazynująca (Niebieski Chlorofit)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.French), "Unité de stockage (Chlorophylle Bleu)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Spanish), "Unidad de Almacenamiento (Clorofita Azul)");
            DisplayName.AddTranslation(GameCulture.FromCultureName(GameCulture.CultureName.Chinese), "存储单元(蓝色叶绿)");
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = 1;
            Item.consumable = true;
            Item.rare = 7;
            Item.value = Item.sellPrice(0, 1, 60, 0);
            Item.createTile = ModContent.TileType<Components.StorageUnit>();
            Item.placeStyle = 5;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Items.StorageUnitHallowed>());
            recipe.AddIngredient(ModContent.ItemType<Items.UpgradeBlueChlorophyte>());
            
            recipe.Create();
        }
    }
}
