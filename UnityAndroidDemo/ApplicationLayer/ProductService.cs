using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidIoc.Core;

namespace ApplicationLayer.BusinessAccess
{
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product {
                    Id =1,
                    Description = "This is an IPhone",
                    Name = "IPhone"},
                new Product {
                    Id =2,
                    Description = "This is a Laptop",
                    Name = "Laptop"}
            };
        }
    }
}