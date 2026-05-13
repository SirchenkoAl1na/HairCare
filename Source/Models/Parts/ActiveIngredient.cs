namespace HairCare.Models.Parts;

public sealed class ActiveIngredient : ProductStat
{
    public ActiveIngredient(string type)
    {
        StatValue = type;
    }
    
    public override string StatName => "Активний інгредієнт";

    public override string StatValue { get; set; }

    public static ActiveIngredient CreateRandom()
    {
        return new ActiveIngredient(Utils.RandomFromStrings(
            "Кератин",
            "Аргінін",
            "Гіалуронова кислота",
            "Колаген",
            "Біотин",
            "Протеїни шовку",
            "Олія аргани"
        ));
    }
}