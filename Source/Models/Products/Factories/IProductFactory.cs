namespace HairCare.Models.Products.Factories;

public interface IProductFactory
{
    ProductBase Create();
    ProductBase CreateRandom();
}