using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Widget;
using Android.OS;
using AndroidIoc.Core;
using TinyIoCAndroidDemo.Adapters;

namespace TinyIoCAndroidDemo
{
    [Activity(Label = "TinyIoC Demo - Products List", MainLauncher = true, Icon = "@drawable/icon")]
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
            var viewModel = TinyIoC.TinyIoCContainer.Current.Resolve<ProductViewModel>();
            var productsList = new List<Product>();
            if (viewModel != null)
            {
                productsList = viewModel.ProductList.ToList();
            }

            //resolving constructor parameters
            //override constructor parameters
            //passing current ativity (this), and products list to the ProductsListAdapter
            var param = new TinyIoC.NamedParameterOverloads { { "context", this }, { "products", productsList } };

            var productListAdapter = TinyIoC.TinyIoCContainer.Current.Resolve<ProductListAdapter>(param);

            //attach the adapter to the listview
            _productsListView.Adapter = productListAdapter;
        }
    }
}

