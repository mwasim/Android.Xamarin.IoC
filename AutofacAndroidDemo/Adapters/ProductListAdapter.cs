using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using AndroidIoc.Core;

namespace AutofacAndroidDemo.Adapters
{
    public class ProductListAdapter : BaseAdapter<Product>
    {
        private readonly List<Product> _productsList;
        private readonly Activity _context;

        public ProductListAdapter()
        {
            
        }

        public ProductListAdapter(Activity context, List<Product> products)
        {
            _context = context;
            _productsList = products;
        }

        //Indexer to retrun a product item on a particular position
        public override Product this[int position]
        {
            get { return _productsList[position]; }
        }

        //Total number of items in the list
        public override int Count
        {
            get { return _productsList.Count; }
        }

        //returns item id, we're simply returning the position
        public override long GetItemId(int position)
        {
            return position;
        }

        //Returns row view in the list
        //There can be hundreds of rows to show however, android shows only displayable rows on the screen
        //Used rows and go off-display are stored in a backyard for later use
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _productsList[position];

            //if its a new row, create a row item
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