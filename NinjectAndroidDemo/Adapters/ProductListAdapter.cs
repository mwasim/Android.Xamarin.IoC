using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using AndroidIoc.Core;

namespace NinjectAndroidDemo.Adapters
{
    public class ProductListAdapter : BaseAdapter<Product>
    {
        private readonly List<Product> _productsList;
        private readonly Activity _context;

        public ProductListAdapter(Activity context, List<Product> products)
        {
            _context = context;
            _productsList = products;
        }

        public override Product this[int position]
        {
            get { return _productsList[position]; }
        }

        public override int Count
        {
            get { return _productsList.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _productsList[position];

            if (convertView == null)
            {
                //Inflating is the process of generating objects based on the XML
                //So, its passing the XML and instantiating the objects

                //Android.Resource.Layout.SimpleListItem1 is a baked-in resource(not in our project)
                convertView = _context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            }

            convertView.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Name;

            return convertView;
        }
    }
}