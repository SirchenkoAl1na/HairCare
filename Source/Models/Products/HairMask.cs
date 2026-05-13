using System.Collections.Generic;

using HairCare.Models.Parts;



namespace HairCare.Models.Products;



public class HairMask : ProductBase

{

    public HairMask(ProductFunction function, Brand brand, PackagingVolume packagingVolume, 

        DispenserType dispenserType, HairType hairType, TargetAudience targetAudience, SeriesYear seriesYear, 

        Color color, ProductModel model, PackagingType packagingType, Extracts extracts, VitaminComplex vitaminComplex, 

        ScentIntensity scentIntensity, LeaveIn leaveIn, ContainsParabens containsParabens, double price) : 

        base(function, brand, packagingVolume, dispenserType, hairType, targetAudience, seriesYear, color, model, price)

    {

        PackagingType = packagingType;

        Extracts = extracts;

        VitaminComplex = vitaminComplex;

        ScentIntensity = scentIntensity;

        LeaveIn = leaveIn;

        ContainsParabens = containsParabens;

    }



    public override ProductType ProductType { get; } = new ProductType("Маска для волосся");



    public PackagingType PackagingType { get; }

    public Extracts Extracts { get; }

    public VitaminComplex VitaminComplex { get; }

    public ScentIntensity ScentIntensity { get; }

    public LeaveIn LeaveIn { get; }

    public ContainsParabens ContainsParabens { get; }

    

    public override IEnumerable<ProductStat> GetStats()

    {

        foreach (var baseStat in base.GetStats())

        {

            yield return baseStat;

        }

        

        

        yield return PackagingType;

        yield return Extracts;

        yield return VitaminComplex;

        yield return ScentIntensity;

        yield return LeaveIn;

        yield return ContainsParabens;

    }

}