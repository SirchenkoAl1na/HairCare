namespace HairCare.Models.Parts;



public sealed class Weight : ProductStat

{

    private int _value;



    public Weight(int value)

    {

        _value = value;

    }

    public override string StatName => "Вага, г";



    public override string StatValue

    {

        get => $"{_value}";

        set => int.TryParse(value, out _value);

    }

}