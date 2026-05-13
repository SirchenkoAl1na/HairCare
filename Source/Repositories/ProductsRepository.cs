using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HairCare.Models;
using HairCare.Models.Parts;

namespace HairCare.Repositories;

public class ProductsRepository
{
    private readonly Dictionary<int, ProductBase> _products = new();

    public Type SortingType;
    public bool Reverse;
    
    public IEnumerable<ProductBase> GetAll(bool useFilter = true)
    {
        var products = 
            useFilter ? _products.Values.OrderBy(p => p.Id).Where(CurrentFilter) : _products.Values.OrderBy(p => p.Id);

        if (SortingType != null)
        {
            products = products.OrderBy(p => SortByPartType(SortingType, p));
        }

        if (Reverse)
        {
            products = products.Reverse();
        }
        
        return products;
    }

    public Func<ProductBase, bool> CurrentFilter = DefaultFilter;
    
    public void Add(ProductBase productBase)
    {
        productBase.Id = GetFreeIdFromBaseId(_products.Count);
        _products.Add(productBase.Id, productBase);
    }

    public void Remove(ProductBase productBase)
    {
        if (_products.Remove(productBase.Id))
        {
            productBase.Id = -1;
        }
    }

    public bool TryGet(int id, out ProductBase productBase)
    {
        return _products.TryGetValue(id, out productBase);
    }

    private int GetFreeIdFromBaseId(int baseId)
    {
        while (_products.ContainsKey(baseId))
        {
            baseId++;
        }

        return baseId;
    }

    public static bool DefaultFilter(ProductBase arg)
    {
        return true;
    }

    public static object SortByPartType(Type type, ProductBase product)
    {
        var prop = product.GetType().GetProperties().Where(pr => pr.PropertyType == type).FirstOrDefault();

        if (type == typeof(double))
        {
            return prop?.GetGetMethod().Invoke(product, null) ?? 0.0;
        }

        var statValueProp = type.GetProperty("StatValue");
        if (statValueProp == null || prop == null)
            return "";

        var value = statValueProp.GetGetMethod().Invoke(prop.GetGetMethod().Invoke(product, null), null) as string ?? "";

        if (type == typeof(SeriesYear))
        {
            if (double.TryParse(value, out double num))
                return num;
        }

        return value;
    }
}