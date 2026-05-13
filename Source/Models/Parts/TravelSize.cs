namespace HairCare.Models.Parts;

public sealed class TravelSize : ProductStat
{
    private string _value;

    public TravelSize(string value)
    {
        _value = value;
    }

    public TravelSize(float size)
    {
        _value = size > 0 ? "Так" : "Ні";
    }

    public override string StatName { get; } = "Travel-версія";

    public override string StatValue
    {
        get => _value;
        set => _value = value;
    }

    public static TravelSize CreateRandom()
    {
        return new TravelSize(Utils.RandomFromStrings("Так", "Ні"));
    }
}