namespace HairCare.Models.Parts;

public sealed class PackagingType : ProductStat
{
    public PackagingType(string statValue)
    {
        StatValue = statValue;
    }

    public override string StatName => "Тип пакування";
    public override string StatValue { get; set; }

    public static PackagingType CreateRandom()
    {
        return new PackagingType(Utils.RandomFromStrings("Пластик", "Скло", "Алюміній", "Пакет", "Картон"));
    }
}