namespace HairCare.Models.Parts;

public sealed class ApplicationMethod : ProductStat
{
    public ApplicationMethod(string statValue)
    {
        StatValue = statValue;
    }

    public override string StatName => "Спосіб застосування";
    public override string StatValue { get; set; }

    public static ApplicationMethod CreateRandom()
    {
        return new ApplicationMethod(Utils.RandomFromStrings(
            "Нанести на мокре волосся, змити",
            "Нанести на сухе волосся",
            "Нанести по довжині, не змивати",
            "Нанести на корені, змити",
            "Нанести по всій довжині, витримати 5 хв, змити"
        ));
    }
}