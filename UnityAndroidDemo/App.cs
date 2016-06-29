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
using Microsoft.Practices.Unity;
using UnityAndroidDemo.Adapters;

namespace UnityAndroidDemo
{
    //Wiring up the container in App class
    [Application]//Application attribute can be used only once throughout the application
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

        public static UnityContainer Container { get; set; }

        private static void Initialize()
        {
            App.Container = new UnityContainer();

            App.Container.RegisterType<IProductService, ProductService>();
            App.Container.RegisterType<BaseAdapter<Product>, ProductListAdapter>();
        }
    }
}