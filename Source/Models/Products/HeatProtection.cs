using System.Collections.Generic;

using HairCare.Models.Parts;



namespace HairCare.Models.Products;



public class HeatProtection : ProductBase

{

    public HeatProtection(ProductFunction function, Brand brand, PackagingVolume packagingVolume, 

        DispenserType dispenserType, HairType hairType, TargetAudience targetAudience, 

        SeriesYear seriesYear, Color color, ProductModel model, PackagingMaterial packagingMaterial, HoldLevel holdLevel, ApplicationMethod applicationMethod, double price) : 

        base(function, brand, packagingVolume, dispenserType, hairType, targetAudience, seriesYear, color, model, price)

    {

        PackagingMaterial = packagingMaterial;

        HoldLevel = holdLevel;

        ApplicationMethod = applicationMethod;

    }

    

    public PackagingMaterial PackagingMaterial { get; }

    public HoldLevel HoldLevel { get; }

    public ApplicationMethod ApplicationMethod { get; }

    

    

    public override ProductType ProductType { get; } = new ProductType("Термозахист");

    

    public override IEnumerable<ProductStat> GetStats()

    {

        foreach (var baseStat in base.GetStats())

        {

            yield return baseStat;

        }



        yield return PackagingMaterial;

        yield return HoldLevel;

        yield return ApplicationMethod;

    }

}