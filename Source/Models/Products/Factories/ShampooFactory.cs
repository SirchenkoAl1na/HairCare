using HairCare.Models.Parts;

namespace HairCare.Models.Products.Factories;

public class ShampooFactory : IProductFactory
{
    public ProductBase Create()
    {
        return new Shampoo(new ProductFunction("Шампунь"),
            new Brand(""),
            new PackagingVolume(""),
            new DispenserType(""),
            new HairType(""),
            new TargetAudience(""),
            new SeriesYear(0),
            new Color(""),
            new ProductModel(""),
            new Weight(0),
            new ProductGeometry(new ConcreteProductStat[7]
            {
                new ConcreteProductStat("Зволоження", ""),
                new ConcreteProductStat("Живлення", ""),
                new ConcreteProductStat("Відновлення", ""),
                new ConcreteProductStat("Блиск", ""),
                new ConcreteProductStat("Захист від пошкоджень", ""),
                new ConcreteProductStat("Від лупи", ""),
                new ConcreteProductStat("Від випадіння", ""),
            }),
            new Texture(""),
            new Effect(""),
            new UVProtection(""),
            new ShelfLife(""),
            0);
    }

    public ProductBase CreateRandom()
    {
        return new Shampoo(new ProductFunction("Шампунь"),
            new Brand(Utils.RandomFromStrings("Loreal", "Pantene", "Garnier", "Head & Shoulders", "Dove", "Redken")),
            PackagingVolume.CreateRandom(),
            DispenserType.CreateRandom(),
            HairType.CreateRandom(), 
            TargetAudience.CreateRandom(16, 65), 
            new SeriesYear(Utils.RandomInRange(2018, 2024)),
            Color.CreateRandom(),
            new ProductModel(Utils.RandomFromStrings("Elseve", "EverPure", "Total Repair", "Color Vive", "Extraordinary")),
            new Weight(Utils.RandomInRange(200, 500)),
            new ProductGeometry(new ConcreteProductStat[7]
            {
                new ConcreteProductStat("Зволоження", Utils.RandomFromStrings("Так", "Ні")),
                new ConcreteProductStat("Живлення", Utils.RandomFromStrings("Так", "Ні")),
                new ConcreteProductStat("Відновлення", Utils.RandomFromStrings("Так", "Ні")),
                new ConcreteProductStat("Блиск", Utils.RandomFromStrings("Так", "Ні")),
                new ConcreteProductStat("Захист від пошкоджень", Utils.RandomFromStrings("Так", "Ні")),
                new ConcreteProductStat("Від лупи", Utils.RandomFromStrings("Так", "Ні")),
                new ConcreteProductStat("Від випадіння", Utils.RandomFromStrings("Так", "Ні")),
            }),
            Texture.CreateRandom(),
            Effect.CreateRandom(),
            UVProtection.CreateRandom(),
            ShelfLife.CreateRandom(),
            Utils.RandomInRange(80, 800));
    }
}