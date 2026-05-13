using HairCare.Models.Parts;

namespace HairCare.Models.Products.Factories;

public class HairMaskFactory : IProductFactory
{
    public ProductBase Create()
    {
        return new HairMask(
            new ProductFunction("Маска для волосся"),
            new Brand(""),
            new PackagingVolume(""),
            new DispenserType(""),
            new HairType(""),
            new TargetAudience(""),
            new SeriesYear(0),
            new Color(""),
            new ProductModel(""),
            new PackagingType(""),
            new Extracts(""),
            new VitaminComplex(""),
            new ScentIntensity(""),
            new LeaveIn(""),
            new ContainsParabens(false),
            0
        );
    }

    public ProductBase CreateRandom()
    {
        return new HairMask(
            new ProductFunction("Маска для волосся"),
            new Brand(Utils.RandomFromStrings("Kerastase", "Schwarzkopf", "Pantene", "Loreal", "Matrix", "Dove")),
            PackagingVolume.CreateRandom(),
            DispenserType.CreateRandom(),
            HairType.CreateRandom(), 
            TargetAudience.CreateRandom(16, 65), 
            new SeriesYear(Utils.RandomInRange(2018, 2024)),
            Color.CreateRandom(),
            new ProductModel(Utils.RandomFromStrings("Nutritive", "Fiberceutic", "Intensive Repair", "Wonder Water", "Fusion")),
            PackagingType.CreateRandom(), 
            Extracts.CreateRandom(),
            VitaminComplex.CreateRandom(),
            ScentIntensity.CreateRandom(),
            LeaveIn.CreateRandom(),
            new ContainsParabens(Utils.RandomBoolean()),
            Utils.RandomInRange(120, 1500)
        );
    }
}