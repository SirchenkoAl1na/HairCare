namespace HairCare.Models.Parts;



public sealed class SeriesYear : ProductStat

{

    private int _year;

    

    public SeriesYear(int year)

    {

        _year = year;

    }



    public override string StatName => "Рік серії";



    public override string StatValue

    {

        get => _year.ToString();

        set => int.TryParse(value, out _year);

    }

}