using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace a1ExpressVol_1
{
    public class MainViewModel
    {
        private Product _oldProduct;
        public ObservableCollection<Product> Products { get; set; }

        public MainViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "View Trip No. 1-12:00PM",
                    IsVisible = false
                },
                new Product
                {
                    Name = "View Trip No 2-3:00PM",
                    IsVisible = false
                },
                new Product
                {
                    Name = "View Trip No 3-3:00PM",
                    IsVisible = false
                }
            };
        }

        public void ShowOrHidePoducts(Product product)
        {
            if (_oldProduct == product)
            {
                
                product.IsVisible = !product.IsVisible;
                UpdateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    
                    _oldProduct.IsVisible = false;
                    UpdateProducts(_oldProduct);
                }
                
                product.IsVisible = true;
                UpdateProducts(product);
            }

            _oldProduct = product;
        }

        private void UpdateProducts(Product product)
        {
            var index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index, product);
        }
    }
}
