namespace HairCare.Models.Parts;

public sealed class ContainsSulfates : ProductStat
{
    private bool _contains;
    
    public ContainsSulfates(bool contains)
    {
        _contains = contains;
    }

    public override string StatName => "Наявність сульфатів";

    public override string StatValue
    {
        get => _contains ? "Є" : "Немає";
        set => _contains = value.Equals("Є");
    }
}