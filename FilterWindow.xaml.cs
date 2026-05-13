using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using HairCare.Models;

namespace HairCare;

public partial class FilterWindow : Window
{
    private readonly IEnumerable<ProductStat> _templateProductStats;

    private readonly Action<IEnumerable<ProductStat>> OnConfirmFilterCallback;
    private readonly Action OnCancelFilterCallback;
    
    public FilterWindow(IEnumerable<ProductStat> templateProductStats, 
        Action<IEnumerable<ProductStat>> onConfirmFilterCallback, Action onCancelFilterCallback)
    {
        _templateProductStats = templateProductStats;
        OnConfirmFilterCallback = onConfirmFilterCallback;
        OnCancelFilterCallback = onCancelFilterCallback;

        InitializeComponent();

        SelectProductView.ItemsSource = _templateProductStats;
    }

    private void OnConfirmFilterClicked(object sender, RoutedEventArgs e)
    {
        for (int itemIndex = 0; itemIndex < SelectProductView.Items.Count; itemIndex++)
        {
            if (SelectProductView.ItemContainerGenerator.ContainerFromIndex(itemIndex) is not ContentPresenter
                itemContainer) 
                continue;
                
            var textBlock = itemContainer.ContentTemplate.FindName("SelectProductViewTextBox", itemContainer) as TextBox;
            textBlock?.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
        }
        
        Close();
        OnConfirmFilterCallback.Invoke(_templateProductStats);
    }

    private void OnCancelFilterClicked(object sender, RoutedEventArgs e)
    {
        Close();
        OnCancelFilterCallback.Invoke();
    }
}