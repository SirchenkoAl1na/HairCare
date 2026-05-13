namespace HairCare.Models.Parts;

public sealed class Brand : ProductStat
{
    public Brand(string partValue)
    {
        StatValue = partValue;
    }

    public override string StatName => "Бренд";
    public override string StatValue { get; set; }
}