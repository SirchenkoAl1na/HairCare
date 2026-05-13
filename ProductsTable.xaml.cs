using System;

using System.Collections.Generic;

using System.Linq;

using System.Windows;

using System.Windows.Controls;

using System.Windows.Data;

using System.Windows.Input;

using System.Xml.Schema;

using HairCare.Models;

using HairCare.Models.Products;

using HairCare.Models.Products.Factories;

using HairCare.Models.Parts;

using HairCare.Repositories;



namespace HairCare

{

    public partial class ProductsTable

    {

        private readonly ProductsRepository _productsRepository = new();

        private IEnumerable<ProductStat> _templateProductStats;

        

        public ProductsTable()

        {

            InitializeComponent();



            SelectProductHidBox.Visibility = Visibility.Visible;

            CompareProductHidBox.Visibility = Visibility.Visible;

            

            const int countToAdd = 2;



            for (int i = 0; i < countToAdd; i++)

            {

                for (int j = 0; j < 5; j++)

                {

                    ProductBase productBase = j switch

                    {

                        0 => new ConditionerFactory().CreateRandom(),

                        1 => new ShampooFactory().CreateRandom(),

                        2 => new HairMaskFactory().CreateRandom(),

                        3 => new HeatProtectionFactory().CreateRandom(),

                        4 => new HairOilFactory().CreateRandom(),

                        _ => throw new ArgumentOutOfRangeException()

                    };

                    

                                

                    _productsRepository.Add(productBase);

                }

            }

            ProductList.ItemsSource = _productsRepository.GetAll();

            UpdateHierarchy();

        }



        private void UpdateHierarchy()

        {

            var nodeView = new NodeView

            {

                Nodes = new List<Node>()

            };



            var balance = _productsRepository.GetAll(false).Where(product => product is Conditioner).ToList();

            var folding = _productsRepository.GetAll(false).Where(product => product is HairOil).ToList();

            var city = _productsRepository.GetAll(false).Where(product => product is HairMask).ToList();

            var shampoo = _productsRepository.GetAll(false).Where(product => product is Shampoo).ToList();

            var mountain = _productsRepository.GetAll(false).Where(product => product is HeatProtection).ToList();



            nodeView.Nodes.AddRange(new[]
            {
                new Node()
                {
                    Name = "Засоби догляду", Nodes = new List<ProductGroup>()
                    {
                        new ProductGroup() { Name = "Кондиціонери", Nodes = balance },
                        new ProductGroup() { Name = "Олійки", Nodes = folding },
                        new ProductGroup() { Name = "Маски", Nodes = city },
                        new ProductGroup() { Name = "Шампуні", Nodes = shampoo },
                        new ProductGroup() { Name = "Термозахист", Nodes = mountain }
                    }
                }
            });

            HierarchicalScheme.ItemsSource = nodeView.Nodes;

        }

        

        private void SetSelectProductPartsView(ProductBase productBase)

        {

            if (productBase == null)

            {

                SelectProductView.ItemsSource = null;

                SelectProductHidBox.Visibility = Visibility.Visible;

                return;

            }

            

            SelectProductView.ItemsSource = productBase.GetStats();

            SelectProductHidBox.Visibility = Visibility.Hidden;

        }

        

        private void SetCompareProductPartsView(ProductBase productBase)

        {

            if (productBase == null)

            {

                CompareProductView.ItemsSource = null;

                CompareProductHidBox.Visibility = Visibility.Visible;

                return;

            }

            

            CompareProductView.ItemsSource = productBase.GetStats();

            CompareProductHidBox.Visibility = Visibility.Hidden;

        }



        private void UpdateProductsTable(bool updateHierarchy = true)

        {

            ProductList.ItemsSource = _productsRepository.GetAll();

            ProductList.Items.Refresh();



            if (updateHierarchy)

            {

                UpdateHierarchy();

            }

        }

        

        private bool Filter(ProductBase productBase)

        {

            foreach (var templatePart in _templateProductStats)

            {

                if (string.IsNullOrEmpty(templatePart.StatValue) || templatePart.StatValue.Equals("0"))

                {

                    continue;

                }



                if (productBase.GetBaseStats().Any(productPart =>

                        productPart.StatName.Equals(templatePart.StatName)

                        && !productPart.StatValue.Equals(templatePart.StatValue)))

                {

                    return false;

                }

            }



            return true;

        }

        

        #region EventHandlers

        private void OnProductListElementClicked(object sender, MouseButtonEventArgs e)

        {

            if (sender is not ListViewItem item || !item.IsSelected) 

                return;



            if (item.DataContext is not ProductBase product)

                return;



            new OperationsDialog(

                () =>

                {

                    SetSelectProductPartsView(product);

                },

                () =>

                {

                    SetCompareProductPartsView(product);

                })

            {

                Owner = this

            }.ShowDialog();

        }



        private void OnDeleteRecordClicked(object sender, RoutedEventArgs e)

        {

            if (ProductList.SelectedItem is not ProductBase product) 

                return;

            

            _productsRepository.Remove(product);

            UpdateProductsTable();

            MessageBox.Show("Запис видалено!");

        }



        private void OnCancelCompareButtonClicked(object sender, RoutedEventArgs e) 

            => CompareProductHidBox.Visibility = Visibility.Visible;



        private void OnCancelSelectButtonClicked(object sender, RoutedEventArgs e) 

            => SelectProductHidBox.Visibility = Visibility.Visible;

        private void OnSaveSelectButtonClicked(object sender, RoutedEventArgs e)

        {

            for (int itemIndex = 0; itemIndex < SelectProductView.Items.Count; itemIndex++)

            {

                if (SelectProductView.ItemContainerGenerator.ContainerFromIndex(itemIndex) is not ContentPresenter

                    itemContainer) 

                    continue;

                

                var textBlock = itemContainer.ContentTemplate.FindName("SelectProductViewTextBox", itemContainer) as TextBox;

                textBlock?.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();

            }

            SelectProductView.Items.Refresh();

            UpdateProductsTable();

            SetSelectProductPartsView(null);

        }

        private void OnCreateProductClicked(object sender, RoutedEventArgs e)

        {

            new CreateProductDialog((product) =>

            {

                _productsRepository.Add(product);

                UpdateProductsTable();

            })

            {

                Owner = this

            }.ShowDialog();

        }

        

        private void OnSortClicked(object sender, RoutedEventArgs e)

        {

            if (_productsRepository.SortingType == null)

            {

                new SortingWindow((type, reverse) =>

                {

                    if (_productsRepository.SortingType == null)

                    {

                        SortingButton.Content = "Відмінити сортування";

                        _productsRepository.SortingType = type;

                        _productsRepository.Reverse = reverse;

                    }

                    

                    UpdateProductsTable(false);

                })

                {

                    Owner = this

                }.ShowDialog();

            }

            else

            {

                SortingButton.Content = "Сортування";

                _productsRepository.SortingType = null;

                _productsRepository.Reverse = false;

                UpdateProductsTable(false);

            }

        }

        

        private void OnFindProductClicked(object sender, RoutedEventArgs e)

        {

            if (_templateProductStats != null)

            {

                _templateProductStats = null;

                _productsRepository.CurrentFilter = ProductsRepository.DefaultFilter;

                UpdateProductsTable();

                FindButton.Content = "Пошук";

                return;

            }

            

            new FilterWindow(

                new ShampooFactory().Create().GetBaseStats(),

                (stats) =>

                {

                    _templateProductStats = stats;

                    _productsRepository.CurrentFilter = Filter;

                    

                    UpdateProductsTable();

                    FindButton.Content = "Очистити фільтр пошуку";

                },

                () => {})

            {

                Owner = this

            }.Show();

        }

        #endregion

    }



    public class NodeView

    {

        public List<Node> Nodes { get; set; }

    }

    

    public class Node

    {

        public string Name { get; set; }

        public List<ProductGroup> Nodes { get; set; }

    }



    public class ProductGroup

    {

        public string Name { get; set; }

        public List<ProductBase> Nodes { get; set; }

    }



    internal class TreeViewLineConverter : IValueConverter

    {

        public object Convert(object value, Type targetType, 

            object parameter, System.Globalization.CultureInfo culture)

        {

            TreeViewItem item = (TreeViewItem)value;

            ItemsControl ic = ItemsControl.ItemsControlFromItemContainer(item);

            return ic.ItemContainerGenerator.IndexFromContainer(item) == ic.Items.Count - 1;

        }



        public object ConvertBack(object value, Type targetType, 

            object parameter, System.Globalization.CultureInfo culture)

        {

            return false;

        }

    }

}