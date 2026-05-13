using System;
using System.Windows;
using HairCare.Models.Parts;

namespace HairCare;

public partial class SortingWindow : Window
{
    private readonly Action<Type, bool> _sortingCallback;
    
    
    public SortingWindow(Action<Type, bool> sortingCallback)
    {
        _sortingCallback = sortingCallback;
        InitializeComponent();
    }
    
    private void OnSortByFunction(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(ProductFunction), Reverse.IsChecked.Value);
        DialogResult = true;
    }

    private void OnSortByBrand(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(Brand), Reverse.IsChecked.Value);
        DialogResult = true;
    }

    private void OnSortByPackagingVolume(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(PackagingVolume), Reverse.IsChecked.Value);
        DialogResult = true;
    }

    private void OnSortByDispenserType(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(DispenserType), Reverse.IsChecked.Value);
        DialogResult = true;
    }

    private void OnSortByHairType(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(HairType), Reverse.IsChecked.Value);
        DialogResult = true;
    }

    private void OnSortByTargetAudience(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(TargetAudience), Reverse.IsChecked.Value);
        DialogResult = true;
    }

    private void OnSortBySeriesYear(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(SeriesYear), Reverse.IsChecked.Value);
        DialogResult = true;
    }

    private void OnSortByColor(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(Color), Reverse.IsChecked.Value);
        DialogResult = true;
    }

    private void OnSortByModel(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(ProductModel), Reverse.IsChecked.Value);
        DialogResult = true;
    }

    private void OnSortByPrice(object sender, RoutedEventArgs e)
    {
        _sortingCallback.Invoke(typeof(double), Reverse.IsChecked.Value);
        DialogResult = true;
    }
}