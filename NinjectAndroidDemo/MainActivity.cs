using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Widget;
using Android.OS;
using AndroidIoc.Core;
using Ninject;
using Ninject.Parameters;
using NinjectAndroidDemo.Adapters;

namespace NinjectAndroidDemo
{
    [Activity(Label = "Ninject Demo - Products List", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ListView _productsListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //initialize controls
            SetupControls();

            //display products
            DisplayProducts();
        }

        private void SetupControls()
        {
            _productsListView = FindViewById<ListView>(Resource.Id.productListView);
        }

        private void DisplayProducts()
        {
            //Resolving dependency in Ninject
            var viewModel = App.Container.Get<ProductViewModel>();
            var productsList = new List<Product>();
            if (viewModel != null)
            {
                productsList = viewModel.ProductList.ToList();
            }

            //passing constructor arguments in Ninject
            var contextArg = new ConstructorArgument("context", this);
            var productsArg = new ConstructorArgument("products", productsList);
            var productListAdapter = App.Container.Get<ProductListAdapter>(contextArg, productsArg);
            
            _productsListView.Adapter = productListAdapter;           
        }
    }
}

