namespace HairCare.Models.Parts;

public sealed class Effect : ProductStat
{
    public Effect(string partValue)
    {
        StatValue = partValue;
    }

    public override string StatName => "Ефект";
    public override string StatValue { get; set; }

    public static Effect CreateRandom()
    {
        return new Effect(Utils.RandomFromStrings(
            "Зволоження",
            "Живлення",
            "Відновлення",
            "Блиск",
            "Захист від ламкості",
            "Від випадіння",
            "Від лупи"
        ));
    }
}