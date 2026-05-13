namespace HairCare.Models.Parts;

public sealed class VitaminComplex : ProductStat
{
    private string _value;

    public VitaminComplex(string value)
    {
        _value = value;
    }

    public VitaminComplex(int count)
    {
        _value = count > 0 ? $"Вітаміни: {count} компонентів" : "Без вітамінного комплексу";
    }

    public override string StatName => "Вітамінний комплекс";

    public override string StatValue
    {
        get => _value;
        set => _value = value;
    }

    public static VitaminComplex CreateRandom()
    {
        return new VitaminComplex(Utils.RandomFromStrings(
            "Вітамін B5 (пантенол)",
            "Вітаміни B5 + E",
            "Вітаміни A, B5, E",
            "Без вітамінного комплексу",
            "Біотин (В7)",
            "Вітамін E + кератин"
        ));
    }
}