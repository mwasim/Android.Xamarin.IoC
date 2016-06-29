using System;
using Android.App;
using Android.Runtime;
using Android.Widget;
using AndroidIoc.Core;
using TinyIoCAndroidDemo.Adapters;

namespace TinyIoCAndroidDemo
{
    [Application]
    public class App : Application
    {
        public App(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {

        }

        public override void OnCreate()
        {
            Initialize();

            base.OnCreate();            
        }

        private static void Initialize()
        {
            //TinyIoC.TinyIoCContainer.Current.AutoRegister() also works 
            //but its performance hit on everytime application starts

            var container = TinyIoC.TinyIoCContainer.Current;

            container.Register<IProductService, ProductService>();
            container.Register<BaseAdapter<Product>, ProductListAdapter>();
        }
    }
}