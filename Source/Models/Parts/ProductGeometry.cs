using System.Collections.Generic;

namespace HairCare.Models.Parts;

public sealed class ProductGeometry : ProductStat
{
    private ConcreteProductStat[] _productStats;

    public ProductGeometry(ConcreteProductStat[] productStats)
    {
        _productStats = productStats;
    }

    public IReadOnlyList<ConcreteProductStat> Stats => _productStats;

    public override string StatName => "Властивості";

    public override string StatValue
    {
        get => BuildPartsText(_productStats);
        set
        {
            string[] stringValues = value.Split('\n');
            ConcreteProductStat[] stats = new ConcreteProductStat[stringValues.Length];
            
            for (int i = 0; i < stringValues.Length; i++)
            {
                var partText = stringValues[i];
                stats[i] = BuildPartFromText(partText);
            }

            _productStats = stats;
        }
    }

    private string BuildPartsText(ConcreteProductStat[] productStat)
    {
        string result = "";
        for (int i = 0; i < productStat.Length; i++)
        {
            result += BuildPartText(productStat[i]);
            if (i != productStat.Length - 1)
            {
                result += "\n";
            }
        }

        return result;
    }
    
    private string BuildPartText(ConcreteProductStat productStat)
    {
        return $"{productStat.StatName}:{productStat.StatValue}";
    }

    private ConcreteProductStat BuildPartFromText(string text)
    {
        string[] stringValues = text.Split(':');
        
        if (stringValues.Length < 2)
        {
            return new ConcreteProductStat("", "");
        }

        return new ConcreteProductStat(stringValues[0], stringValues[1]);
    }
}