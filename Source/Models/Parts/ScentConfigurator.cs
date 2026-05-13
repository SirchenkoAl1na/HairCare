namespace HairCare.Models.Parts;

public sealed class ScentConfigurator : ConfiguratorStat
{
    public ScentConfigurator(float min, float max) : base(min, max)
    {
    }

    public override string StatName => "Діапазон об'єму, мл";
}