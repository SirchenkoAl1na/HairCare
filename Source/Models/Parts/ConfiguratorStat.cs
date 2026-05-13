namespace HairCare.Models.Parts;

public abstract class ConfiguratorStat : ProductStat
{
    private float _min;
    private float _max;

    public ConfiguratorStat(float min, float max)
    {
        _min = min;
        _max = max;
    }
    
    public override string StatValue
    {
        get => $"{_min}-{_max}";
        set
        {
            string[] stringValues = value.Split(',');

            if (stringValues.Length <= 0)
            {
                _min = 0;
                _max = 0;
                return;
            }

            if (stringValues.Length == 1)
            {
                float.TryParse(stringValues[0], out _min);
                _max = 0;
                return;
            }

            if (stringValues.Length < 2) 
                return;
            
            float.TryParse(stringValues[0], out _min);
            float.TryParse(stringValues[1], out _max);
        }
    }
}