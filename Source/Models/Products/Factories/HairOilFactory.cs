using HairCare.Models.Parts;

namespace HairCare.Models.Products.Factories;

public class HairOilFactory : IProductFactory
{
    public ProductBase Create()
    {
        return new HairOil(
            new ProductFunction("Олійка для волосся"),
            new Brand(""),
            new PackagingVolume(""),
            new DispenserType(""),
            new HairType(""),
            new TargetAudience(""),
            new SeriesYear(0),
            new Color(""),
            new ProductModel(""),
            new TravelSize(""),
            new Weight(0), 
            0);
    }

    public ProductBase CreateRandom()
    {
        return new HairOil(
           new ProductFunction("Олійка для волосся"),
           new Brand(Utils.RandomFromStrings("Moroccanoil", "Loreal", "Nioxin", "Wella", "Kerastase")),
           PackagingVolume.CreateRandom(), 
           DispenserType.CreateRandom(),
           HairType.CreateRandom(), 
           TargetAudience.CreateRandom(18, 65),
           new SeriesYear(Utils.RandomInRange(2018, 2024)),
           Color.CreateRandom(),
           new ProductModel(Utils.RandomFromStrings("Argan Oil", "Elixir Ultime", "Mythic Oil", "Oil Reflections", "Pure")),
           TravelSize.CreateRandom(),
           new Weight(Utils.RandomInRange(50, 200)),
           Utils.RandomInRange(150, 1200));
    }
}