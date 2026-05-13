namespace HairCare.Models.Parts;



public sealed class TargetAudience : ProductStat

{

    public TargetAudience(string partValue)

    {

        StatValue = partValue;

    }



    public override string StatName => "Цільова аудиторія";

    public override string StatValue { get; set; }



    public static TargetAudience CreateRandom(int minAge, int maxAge)

    {

        return

            new TargetAudience($"{Utils.RandomFromStrings("Чол", "Жін", "Уні")}, " +

                               $"{Utils.RandomInRange(minAge, maxAge)}");

    }

}