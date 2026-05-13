namespace HairCare.Models.Parts;

public sealed class Extracts : ProductStat
{
    public Extracts(string statValue)
    {
        StatValue = statValue;
    }

    public override string StatName => "Екстракти";
    public override string StatValue { get; set; }

    public static Extracts CreateRandom()
    {
        return new Extracts(Utils.RandomFromStrings(
            "Екстракт кератину",
            "Екстракт аргани",
            "Екстракт жожоба",
            "Екстракт кокосу",
            "Екстракт алое вера",
            "Екстракт ромашки"
        ));
    }
}