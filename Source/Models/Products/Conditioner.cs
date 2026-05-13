using System.Collections.Generic;

using HairCare.Models.Parts;



namespace HairCare.Models.Products;



public sealed class Conditioner : ProductBase

{

    public Conditioner( ProductFunction function, Brand brand, PackagingVolume packagingVolume,

        DispenserType dispenserType, HairType hairType, TargetAudience targetAudience, 

        SeriesYear seriesYear, Color color, ProductModel model, ScentConfigurator scentConfigurator, 

        PackagingConfigurator packagingConfigurator, PackagingType packagingType, Weight weight, ContainsSulfates containsSulfates, 

        AgeGroup ageGroup, double price) : 

        base(function, brand, packagingVolume, dispenserType, hairType, targetAudience, seriesYear, color, model, price)

    {

        ScentConfigurator = scentConfigurator;

        PackagingConfigurator = packagingConfigurator;

        PackagingType = packagingType;

        Weight = weight;

        ContainsSulfates = containsSulfates;

        AgeGroup = ageGroup;

    }

    

    public ScentConfigurator ScentConfigurator { get; }

    public PackagingConfigurator PackagingConfigurator { get; }

    public PackagingType PackagingType { get; }

    public Weight Weight { get; }

    public ContainsSulfates ContainsSulfates { get; }

    public AgeGroup AgeGroup { get; }



    public override ProductType ProductType { get; } = new ProductType("Кондиціонер");

    

    public override IEnumerable<ProductStat> GetStats()

    {

        foreach (var baseStat in base.GetStats())

        {

            yield return baseStat;

        }



        yield return ScentConfigurator;

        yield return PackagingConfigurator;

        yield return PackagingType;

        yield return Weight;

        yield return ContainsSulfates;

        yield return AgeGroup;

    }

}