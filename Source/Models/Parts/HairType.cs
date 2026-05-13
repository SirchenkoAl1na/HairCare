namespace HairCare.Models.Parts;

public sealed class HairType : ProductStat
{
    public HairType(string type)
    {
        StatValue = type;
    }
    
    public override string StatName => "Тип волосся";
    public override string StatValue { get; set; }
    
    public static HairType CreateRandom()
    {
        string[] hairTypes = {
            "Сухе",
            "Жирне",
            "Нормальне",
            "Пошкоджене",
            "Фарбоване",
            "Кучеряве",
            "Тонке та ламке",
        };

        return new HairType(hairTypes[Utils.Random.Next(0, hairTypes.Length)]);
    }
}