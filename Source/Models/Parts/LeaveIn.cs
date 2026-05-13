namespace HairCare.Models.Parts;

public sealed class LeaveIn : ProductStat
{
    public LeaveIn(string type)
    {
        StatValue = type;
    }
    
    public override string StatName => "Незмивний догляд";
    public override string StatValue { get; set; }

    public static LeaveIn CreateRandom()
    {
        return new LeaveIn(Utils.RandomFromStrings("Так", "Ні"));
    }
}