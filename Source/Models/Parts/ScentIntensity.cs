namespace HairCare.Models.Parts;

public sealed class ScentIntensity : ProductStat
{
    public ScentIntensity(string type)
    {
        StatValue = type;
    }
    
    public override string StatName => "Інтенсивність аромату";
    public override string StatValue { get; set; }

    public static ScentIntensity CreateRandom()
    {
        return new ScentIntensity(Utils.RandomFromStrings(
            "Без аромату",
            "Легкий",
            "Середній",
            "Насичений"
        ));
    }
}