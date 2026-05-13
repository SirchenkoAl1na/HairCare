using HairCare.Models.Parts;

namespace HairCare.Models.Products.Factories;

public class ConditionerFactory : IProductFactory
{
    public ProductBase Create()
    {
        return new Conditioner(
                new ProductFunction("Кондиціонер"),
                new Brand(""),
                new PackagingVolume(""),
                new DispenserType(""),
                new HairType(""),
                new TargetAudience(""),
                new SeriesYear(0),
                new Color(""),
                new ProductModel(""),
                new ScentConfigurator(0, 0),
                new PackagingConfigurator(0, 0),
                new PackagingType(""),
                new Weight(0),
                new ContainsSulfates(false),
                new AgeGroup(""),
                0);
    }

    public ProductBase CreateRandom()
    {
        return new Conditioner(
            new ProductFunction("Кондиціонер"),
            new Brand(Utils.RandomFromStrings("Pantene", "Loreal", "Herbal Essences", "Garnier", "Dove", "Kerastase")),
            PackagingVolume.CreateRandom(),
            DispenserType.CreateRandom(),
            HairType.CreateRandom(),
            TargetAudience.CreateRandom(14, 65),
            new SeriesYear(Utils.RandomInRange(2018, 2024)),
            Color.CreateRandom(),
            new ProductModel(Utils.RandomFromStrings("Pro-V", "Miraculour", "Liss Unlimited", "Smooth Intense", "Fiber Frizz")),
            new ScentConfigurator(Utils.RandomInRange(100, 300), Utils.RandomInRange(300, 500)),
            new PackagingConfigurator(Utils.RandomInRange(200, 400), Utils.RandomInRange(400, 600)),
            PackagingType.CreateRandom(),
            new Weight(Utils.RandomInRange(200, 500)),
            new ContainsSulfates(Utils.RandomBoolean()),
            AgeGroup.CreateRandom(),
            Utils.RandomInRange(80, 700));
    }
}