namespace HairCare.Models.Parts;

public sealed class ShelfLife : ProductStat
{
    public ShelfLife(string statValue)
    {
        StatValue = statValue;
    }

    public override string StatName => "Термін придатності (міс.)";
    public override string StatValue { get; set; }

    public static ShelfLife CreateRandom()
    {
        return new ShelfLife(Utils.RandomFromStrings("12", "18", "24", "36"));
    }
}