using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Barcelona.LocalStorageHandler;

namespace Barcelona
{
    public class TicketsDialogFragment : DialogFragment
    {
        TextView priceTextview, buyTicketsTextview;

        Helper.enumTab tab;

        public TicketsDialogFragment()
        {
        }

        public TicketsDialogFragment(Helper.enumTab tab)
        {
            this.tab = tab;
        }

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            var dialog =  base.OnCreateDialog(savedInstanceState);

            dialog.Window.RequestFeature(WindowFeatures.NoTitle);//hide title

            return dialog;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.TicketsDialogFragment, container, false);

            priceTextview = view.FindViewById<TextView>(Resource.Id.textview_price);
            buyTicketsTextview = view.FindViewById<TextView>(Resource.Id.textview_link);

            Initialize();

            return view;
        }

        private void Initialize()
        {
            priceTextview.Text = "Price " + LocalStorageGetText.GetPrice(tab) + "€";

            buyTicketsTextview.PaintFlags = Android.Graphics.PaintFlags.UnderlineText;

            buyTicketsTextview.Click += (sender, e) =>
              {
                  var link = LocalStorageGetText.GetLink(tab);

                  if (!String.IsNullOrEmpty(link))
                  {
                      var uri = Android.Net.Uri.Parse(link);

                      var intent = new Intent(Intent.ActionView, uri);
                      StartActivity(intent);
                  }
              };
        }
    }
}
