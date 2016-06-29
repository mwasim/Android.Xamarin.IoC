using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Widget;
using Android.OS;
using AndroidIoc.Core;
using Autofac;
using AutofacAndroidDemo.Adapters;

namespace AutofacAndroidDemo
{
    [Activity(Label = "Autofac Demo - Products List", MainLauncher = true, Icon = "@drawable/icon")]
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
            ProductViewModel viewModel;
            using (var scope = App.Container.BeginLifetimeScope())
            {
                viewModel = App.Container.Resolve<ProductViewModel>();
            }

            var productsList = new List<Product>();
            if (viewModel != null)
            {
                productsList = viewModel.ProductList.ToList();
            }

            ProductListAdapter productListAdapter;
            using (var scope = App.Container.BeginLifetimeScope())
            {
                productListAdapter = App.Container.Resolve<ProductListAdapter>(
                    new NamedParameter("context", this),
                    new NamedParameter("products", productsList)
                    );
            }

            //attach the adapter to the listview
            _productsListView.Adapter = productListAdapter;
        }
    }
}

