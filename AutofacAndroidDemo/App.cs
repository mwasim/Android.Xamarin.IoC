using System;

using Android.App;
using Android.Runtime;
using Android.Widget;
using AndroidIoc.Core;
using Autofac;
using AutofacAndroidDemo.Adapters;

namespace AutofacAndroidDemo
{
    [Application]
    public class App : Application
    {
        public static IContainer Container { get; set; }

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
            var builder = new ContainerBuilder();

            builder.RegisterInstance(new ProductService()).As<IProductService>();
            builder.RegisterType<ProductViewModel>();

            builder.RegisterInstance(new ProductListAdapter()).As<BaseAdapter<Product>>();
            builder.RegisterType<ProductListAdapter>();

            App.Container = builder.Build();
        }
    }
}