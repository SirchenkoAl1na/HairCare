namespace HairCare.Models.Parts;



public sealed class ProductModel : ProductStat

{

    public ProductModel(string partValue)

    {

        StatValue = partValue;

    }



    public override string StatName => "Лінійка";

    public override string StatValue { get; set; }

}