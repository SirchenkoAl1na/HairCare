using System.Collections.Generic;

using HairCare.Models.Parts;



namespace HairCare.Models

{

    public abstract class ProductBase

    {

        public ProductBase(ProductFunction function, Brand brand, PackagingVolume packagingVolume, 

            DispenserType dispenserType, HairType hairType, TargetAudience targetAudience, 

            SeriesYear seriesYear, Color color, ProductModel model, double price)

        {

            Function = function;

            Brand = brand;

            PackagingVolume = packagingVolume;

            DispenserType = dispenserType;

            HairType = hairType;

            TargetAudience = targetAudience;

            SeriesYear = seriesYear;

            Color = color;

            Model = model;

            Price = price;

        }



        public int Id { get; set; } = -1;

        public double Price { get; set; }

        public ProductFunction Function { get; }

        public Brand Brand { get; }

        public PackagingVolume PackagingVolume { get; }

        public DispenserType DispenserType { get; }

        public HairType HairType { get; }

        public TargetAudience TargetAudience { get; }

        public SeriesYear SeriesYear { get; }

        public Color Color { get; }

        public ProductModel Model { get; }

        

        public abstract ProductType ProductType { get; }

        public IEnumerable<ProductBase> Nodes => null;



        public string Name => $"{Color.StatValue} {Brand.StatValue} {Model.StatValue} {SeriesYear.StatValue}";



        public virtual IEnumerable<ProductStat> GetStats()

        {

            foreach (var part in GetBaseStats())

            {

                yield return part;

            }

        }



        public IEnumerable<ProductStat> GetBaseStats()

        {

            yield return Function;

            yield return Brand;

            yield return PackagingVolume;

            yield return DispenserType;

            yield return HairType;

            yield return TargetAudience;

            yield return SeriesYear;

            yield return Color;

            yield return Model;

        }

    }

}