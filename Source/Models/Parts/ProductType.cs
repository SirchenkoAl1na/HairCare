namespace HairCare.Models.Parts;



public sealed class ProductType : ProductStat

{

    public ProductType(string partValue)

    {

        StatValue = partValue;

    }



    public override string StatName => "Тип";

    public override string StatValue { get; set; }

}

