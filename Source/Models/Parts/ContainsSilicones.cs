namespace HairCare.Models.Parts;

public sealed class ContainsSilicones : ProductStat
{
    private bool _contains;
    
    public ContainsSilicones(bool contains)
    {
        _contains = contains;
    }

    public override string StatName => "Наявність силіконів";

    public override string StatValue
    {
        get => _contains ? "Є" : "Немає";
        set => _contains = value.Equals("Є");
    }
}