namespace HairCare.Models.Parts;

public sealed class ContainsParabens : ProductStat
{
    private bool _contains;
    
    public ContainsParabens(bool contains)
    {
        _contains = contains;
    }

    public override string StatName => "Наявність парабенів";

    public override string StatValue
    {
        get => _contains ? "Є" : "Немає";
        set => _contains = value.Equals("Є");
    }
}
