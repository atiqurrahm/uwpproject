using Food_Product.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Food_Product
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

            ProductRepo repo;
            public MainPage()
            {
                this.InitializeComponent();
                this.repo = new ProductRepo();
                this.listProducts.ItemsSource = this.repo.Get();
            }

            private void listProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                var selected = this.listProducts.SelectedItem as Product;
                this.Frame.Navigate(typeof(ProductDetail), new PageNavParam { Id = selected.Id });
            }
        
    }
}
