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
using Ninject;

namespace NinjectAndroidDemo
{
    [Application]
    public class App : Application
    {
        public static IKernel Container { get; set; }
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
            var kernel = new StandardKernel(new NinjectCustomModule());

            App.Container = kernel;
        }
    }
}