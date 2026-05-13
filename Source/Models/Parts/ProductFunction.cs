namespace HairCare.Models.Parts;



public sealed class ProductFunction : ProductStat

{

    public ProductFunction(string partValue)

    {

        StatValue = partValue;

    }



    public override string StatName => "Призначення";



    public override string StatValue { get; set; }

}