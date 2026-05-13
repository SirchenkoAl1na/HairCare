namespace HairCare.Models.Parts;

public sealed class Color : ProductStat
{
    public Color(string scentName)
    {
        StatValue = scentName;
    }
    
    public override string StatName => "Аромат";
    public override string StatValue { get; set; }

    public static Color CreateRandom()
    {
        Color[] scents = {
            Floral,
            Fresh,
            Citrus,
            Coconut,
            Lavender,
            Unscented
        };

        return scents[Utils.Random.Next(0, scents.Length)];
    }

    public static readonly Color Floral = new("Квітковий");
    public static readonly Color Fresh = new("Свіжий");
    public static readonly Color Citrus = new("Цитрусовий");
    public static readonly Color Coconut = new("Кокосовий");
    public static readonly Color Lavender = new("Лавандовий");
    public static readonly Color Unscented = new("Без аромату");
}