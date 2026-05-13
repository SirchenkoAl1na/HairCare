using System.Collections.Generic;

using HairCare.Models.Parts;



namespace HairCare.Models.Products;



public class HairOil : ProductBase

{

    public HairOil(ProductFunction function, Brand brand, PackagingVolume packagingVolume, 

        DispenserType dispenserType, HairType hairType, TargetAudience targetAudience, 

        SeriesYear seriesYear, Color color, ProductModel model, TravelSize travelSize, Weight weight, double price) : 

        base(function, brand, packagingVolume, dispenserType, hairType, targetAudience, seriesYear, color, model, price)

    {

        TravelSize = travelSize;

        Weight = weight;

    }



    public TravelSize TravelSize { get; }

    public Weight Weight { get; }

    

    public override ProductType ProductType { get; } = new ProductType("Олійка");

    

    public override IEnumerable<ProductStat> GetStats()

    {

        foreach (var baseStat in base.GetStats())

        {

            yield return baseStat;

        }



        yield return TravelSize;

        yield return Weight;

    }

}