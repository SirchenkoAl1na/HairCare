namespace HairCare.Models.Parts;

public sealed class HoldLevel : ProductStat
{
    public HoldLevel(string level)
    {
        StatValue = level;
    }

    public override string StatName => "Рівень фіксації";
    public override string StatValue { get; set; }

    public static HoldLevel CreateRandom()
    {
        return new HoldLevel(Utils.RandomFromStrings("Слабкий", "Середній", "Сильний", "Екстрасильний", "Без фіксації"));
    }
}