using System;

using System.Windows;

using System.Windows.Controls;

using HairCare.Models;



namespace HairCare;



public partial class CreateProductWindow : Window

{

    private readonly Action<ProductBase> _productCreatedCallback;

    private readonly ProductBase _product;

    

    public CreateProductWindow(

        ProductBase product,

        Action<ProductBase> productCreatedCallback)

    {

        _product = product;

        _productCreatedCallback = productCreatedCallback;

        InitializeComponent();



        SelectProductView.ItemsSource = product.GetStats();

        SelectProductView.Items.Refresh();

    }



    private void OnConfirmClicked(object sender, RoutedEventArgs e)

    {

        for (int itemIndex = 0; itemIndex < SelectProductView.Items.Count; itemIndex++)

        {

            if (SelectProductView.ItemContainerGenerator.ContainerFromIndex(itemIndex) is not ContentPresenter

                itemContainer) 

                continue;

                

            var textBlock = itemContainer.ContentTemplate.FindName("SelectProductViewTextBox", itemContainer) as TextBox;

            textBlock?.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();

        }

        

        _productCreatedCallback.Invoke(_product);

        DialogResult = true;

    }



    private void OnCancelClicked(object sender, RoutedEventArgs e)

    {

        DialogResult = true;

        Close();

    }

}