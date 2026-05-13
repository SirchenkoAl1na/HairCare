namespace HairCare.Models.Parts;

public sealed class AgeGroup : ProductStat
{
    private string _value;

    public AgeGroup(string value)
    {
        _value = value;
    }

    public AgeGroup(float height)
    {
        _value = $"{height}+";
    }

    public override string StatName => "Вікова категорія";
    
    public override string StatValue
    {
        get => _value;
        set => _value = value;
    }

    public static AgeGroup CreateRandom()
    {
        return new AgeGroup(Utils.RandomFromStrings(
            "Дорослі",
            "Діти (від 3 років)",
            "Підлітки",
            "Для всіх"
        ));
    }
}