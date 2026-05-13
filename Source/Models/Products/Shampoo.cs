using System.Collections.Generic;

using HairCare.Models.Parts;



namespace HairCare.Models.Products;



public sealed class Shampoo : ProductBase

{

    public Shampoo(ProductFunction function, Brand brand, PackagingVolume packagingVolume, 

        DispenserType dispenserType, HairType hairType, TargetAudience targetAudience, 

        SeriesYear seriesYear, Color color, ProductModel model, Weight weight, ProductGeometry geometry, 

        Texture texture, Effect effect, UVProtection uvProtection, ShelfLife shelfLife, double price) : 

        base(function, brand, packagingVolume, dispenserType, hairType, targetAudience, seriesYear, color, model, price)

    {

        Weight = weight;

        Geometry = geometry;

        Texture = texture;

        Effect = effect;

        UVProtection = uvProtection;

        ShelfLife = shelfLife;

    }



    public Weight Weight { get; }

    public ProductGeometry Geometry { get; }

    public Texture Texture { get; }

    public Effect Effect { get; }

    public UVProtection UVProtection { get; }

    public ShelfLife ShelfLife { get; }

    

    public override ProductType ProductType { get; } = new ProductType("Шампунь");

    

    public override IEnumerable<ProductStat> GetStats()

    {

        foreach (var baseStat in base.GetStats())

        {

            yield return baseStat;

        }



        yield return Weight;

        foreach (var stat in Geometry.Stats)

        {

            yield return stat;

        }

        yield return Texture;

        yield return Effect;

        yield return UVProtection;

        yield return ShelfLife;

    }

}