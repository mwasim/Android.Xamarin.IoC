using Android.Widget;
using AndroidIoc.Core;
using Ninject.Modules;
using NinjectAndroidDemo.Adapters;

namespace NinjectAndroidDemo
{
    public class NinjectCustomModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IProductService>().To<ProductService>();
            this.Bind<BaseAdapter<Product>>().To<ProductListAdapter>();
        }
    }
}