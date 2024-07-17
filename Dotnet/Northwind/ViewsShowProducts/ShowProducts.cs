using ENV;
using ENV.Data;
using Firefly.Box;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Northwind.ViewsShowProducts
{
    public class ShowProducts : UIControllerBase
    {
        public readonly Models.Products products = new Models.Products();
        public ShowProducts()
        {
            From = products;
            Where.Add(products.ProductName.StartsWith("C"));
        }

        public void Run()
        {
            Execute();
        }

        protected override void OnLoad()
        {
            View = () => new Views.ShowProductsView(this);
        }
    }
}