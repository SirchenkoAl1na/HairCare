namespace HairCare.Models

{

    public abstract class ProductStat

    {

        public abstract string StatName { get; }

        public abstract string StatValue { get; set; }

    }



    public sealed class ConcreteProductStat : ProductStat

    {

        public ConcreteProductStat(string statName, string statValue)

        {

            StatName = statName;

            StatValue = statValue;

        }



        public override string StatName { get; }

        public override string StatValue { get; set; }

    }

}