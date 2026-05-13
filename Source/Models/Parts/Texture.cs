namespace HairCare.Models.Parts;

public sealed class Texture : ProductStat
{
    public Texture(string texture)
    {
        StatValue = texture;
    }

    public override string StatName => "Текстура";
    public override string StatValue { get; set; }

    public static Texture CreateRandom()
    {
        return new Texture(Utils.RandomFromStrings("Крем", "Гель", "Піна", "Сироватка", "Олія", "Бальзам", "Спрей"));
    }
}