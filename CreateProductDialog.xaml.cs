using System;

using System.Windows;

using HairCare.Models;

using HairCare.Models.Products;

using HairCare.Models.Products.Factories;



namespace HairCare;



public partial class CreateProductDialog : Window

{

    private readonly Action<ProductBase> _productCreatedCallback;

    

    public CreateProductDialog(Action<ProductBase> productCreatedCallback)

    {

        _productCreatedCallback = productCreatedCallback;

        InitializeComponent();

    }



    private void CreateBalance(object sender, RoutedEventArgs e)

    {

        ShowCreateWindow(new ConditionerFactory().Create());

        DialogResult = true;

    }

    

    private void CreateCity(object sender, RoutedEventArgs e)

    {

        ShowCreateWindow(new HairMaskFactory().Create());

        DialogResult = true;

    }



    private void CreateFolding(object sender, RoutedEventArgs e)

    {

        ShowCreateWindow(new HairOilFactory().Create());

        DialogResult = true;

    }



    private void CreateMountain(object sender, RoutedEventArgs e)

    {

        ShowCreateWindow(new HeatProtectionFactory().Create());

        DialogResult = true;

    }



    private void CreateShampoo(object sender, RoutedEventArgs e)

    {

        ShowCreateWindow(new ShampooFactory().Create());

        DialogResult = true;

    }



    private void ShowCreateWindow(ProductBase product)

    {

        new CreateProductWindow(product, _productCreatedCallback)

            .ShowDialog();

    }

}