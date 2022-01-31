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
    public class ImageDialogFragment : DialogFragment
    {
        TextView titleTextview;
        ImageButton imageImageButton;

        Helper.enumImages image;

        public ImageDialogFragment()
        {
        }

        public ImageDialogFragment(Helper.enumImages image)
        {
            this.image = image;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.ImageDialogFragment, container, false);

            titleTextview = view.FindViewById<TextView>(Resource.Id.textview_title);
            imageImageButton = view.FindViewById<ImageButton>(Resource.Id.imagebutton_image);

            GetData();

            return view;
        }

        private void GetData()
        {
            titleTextview.Text = LocalStorageGetText.GetImageTitle(image);

            imageImageButton.SetImageDrawable(Resources.GetDrawable(LocalStorageGetText.GetImage(image)));
        }
    }
}
