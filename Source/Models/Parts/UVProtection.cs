namespace HairCare.Models.Parts;

public sealed class UVProtection : ProductStat
{
    public UVProtection(string partValue)
    {
        StatValue = partValue;
    }

    public override string StatName => "УФ-захист";
    public override string StatValue { get; set; }

    public static UVProtection CreateRandom()
    {
        return new UVProtection(Utils.RandomFromStrings("Так", "Ні"));
    }
}