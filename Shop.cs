using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    class Shop
    {
        private Dictionary<Product, int> products;
      
        public Shop ()
        {
            products = new Dictionary<Product, int>();
        }
        public decimal Profit
        {
            get;
            set;
        }

        public void CreateProduct (string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }
        public void WriteAllProducts (ListBox listbox)
        {
            foreach (var product in products)
            {
                listbox.Items.Add(product.Key.GetInfo() + $"; Количество: {product.Value}");
            }
        }
        public void Sell (Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    MessageBox.Show("Нет в наличии!");
                } else if (products[product] < count)
                {
                    MessageBox.Show("Столько товара нет в наличии");
                } else
                {
                    products[product] -= count;
                }
            } else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        public void Sell (string ProductName, int count)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {              
                    Profit += ToSell.Price * count;
                    this.Sell(ToSell, count);
              
            } 
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }

        

        public Product FindByName (string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    continue;
                }
                return product;
            }
            return null;
        }

    }
}
