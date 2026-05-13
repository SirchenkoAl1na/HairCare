namespace HairCare.Models.Parts;

public sealed class PackagingVolume : ProductStat
{
    public PackagingVolume(string size)
    {
        StatValue = size;
    }

    public override string StatName { get; } = "Об'єм пакування, мл";

    public override string StatValue { get; set; }

    public static PackagingVolume CreateRandom()
    {
        string[] values = { "50", "100", "150", "200", "250", "300", "400", "500" };
        return new PackagingVolume(Utils.RandomFromStrings(values));
    }

    public static PackagingVolume CreateRandom(int min, int max)
    {
        string[] values = { "50", "100", "150", "200", "250", "300", "400", "500" };
        int index = Utils.RandomInRange(min, max < values.Length ? max : values.Length - 1);
        return new PackagingVolume(values[index]);
    }
}