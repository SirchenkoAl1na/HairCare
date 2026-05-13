namespace HairCare.Models.Parts;

public sealed class DispenserType : ProductStat
{
    private string _type;

    public DispenserType(string type)
    {
        _type = type;
    }
    
    public override string StatName => "Тип дозатора";

    public override string StatValue
    {
        get => _type;
        set => _type = value;
    }

    public static DispenserType CreateRandom()
    {
        return new DispenserType(Utils.RandomFromStrings("Помпа", "Спрей", "Тюбик", "Флакон з кришкою", "Без дозатора"));
    }
}