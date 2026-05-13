using HairCare.Models.Parts;

namespace HairCare.Models.Products.Factories;

public class HeatProtectionFactory : IProductFactory
{
    public ProductBase Create()
    {
        return new HeatProtection(
            new ProductFunction("Термозахист"),
            new Brand(""),
            new PackagingVolume(""),
            new DispenserType(""),
            new HairType(""),
            new TargetAudience(""),
            new SeriesYear(0),
            new Color(""),
            new ProductModel(""),
            new PackagingMaterial(""),
            new HoldLevel(""),
            new ApplicationMethod(""),
            0
        );
    }

    public ProductBase CreateRandom()
    {
        return new HeatProtection(
            new ProductFunction(Utils.RandomFromStrings("Термозахист-спрей", "Термозахист-крем", "Термозахист-сироватка")),
            new Brand(Utils.RandomFromStrings("Tresemme", "Wella", "Schwarzkopf", "Kerastase", "Matrix")),
            PackagingVolume.CreateRandom(), 
            DispenserType.CreateRandom(),
            HairType.CreateRandom(), 
            TargetAudience.CreateRandom(18, 65), 
            new SeriesYear(Utils.RandomInRange(2018, 2024)),
            Color.CreateRandom(),
            new ProductModel(Utils.RandomFromStrings("Heat Me Up", "Blondme", "Thermal Activ", "Thermique", "Defend")),
            PackagingMaterial.CreateRandom(),
            HoldLevel.CreateRandom(),
            ApplicationMethod.CreateRandom(),
            Utils.RandomInRange(100, 900)
        );
    }
}