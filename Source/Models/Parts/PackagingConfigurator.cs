namespace HairCare.Models.Parts;

public sealed class PackagingConfigurator : ConfiguratorStat
{
    public PackagingConfigurator(float min, float max) : base(min, max)
    {
    }

    public override string StatName => "Рекомендована вага упаковки, г";
}