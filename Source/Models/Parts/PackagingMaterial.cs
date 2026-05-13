namespace HairCare.Models.Parts;

public sealed class PackagingMaterial : ProductStat
{
    public PackagingMaterial(string materialName)
    {
        StatValue = materialName;
    }

    public override string StatName { get; } = "Матеріал пакування";
    public override string StatValue { get; set; }

    public static PackagingMaterial CreateRandom()
    {
        return new PackagingMaterial(Utils.RandomFromStrings("Пластик", "Скло", "Алюміній", "Картон"));
    }
}