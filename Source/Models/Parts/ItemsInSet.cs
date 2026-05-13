namespace HairCare.Models.Parts;

public sealed class ItemsInSet : ProductStat
{
    private int _count;

    public ItemsInSet(int count)
    {
        _count = count;
    }
    
    public override string StatName => "Кількість в наборі";

    public override string StatValue
    {
        get => $"{_count}";
        set => int.TryParse(value, out _count);
    }

    public static ItemsInSet CreateRandom()
    {
        return new ItemsInSet(Utils.RandomInRange(1, 5));
    }
}