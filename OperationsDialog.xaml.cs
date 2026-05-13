using System;
using System.Windows;

namespace HairCare;

public partial class OperationsDialog : Window
{
    private readonly Action _selectOperationCallback;
    private readonly Action _compareOperationCallback;
    
    public OperationsDialog(Action selectOperationCallback, Action compareOperationCallback)
    {
        _selectOperationCallback = selectOperationCallback;
        _compareOperationCallback = compareOperationCallback;
        InitializeComponent();
    }
    
    private void OnCompareClick(object sender, RoutedEventArgs e)
    {
        _compareOperationCallback.Invoke();
        DialogResult = true;
    }
    
    private void OnSelectClick(object sender, RoutedEventArgs e)
    {
        _selectOperationCallback.Invoke();
        DialogResult = true;
    }
}