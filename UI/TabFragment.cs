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
    public class TabFragment : Fragment
    {
        TextView toolbar_textview, text_textview;
        ImageButton button_image1, button_image2;

        int enumTab = 1;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.TabFragment, container, false);

            text_textview = (TextView)view.FindViewById(Resource.Id.textview_text);
            button_image1 = (ImageButton)view.FindViewById(Resource.Id.button_image1);
            button_image2 = (ImageButton)view.FindViewById(Resource.Id.button_image2);

            GetText();

            GetImages();

            return view;
        }

        public static TabFragment NewInstance(int enumTab)
        {
            TabFragment fragment = new TabFragment();
            fragment.enumTab = enumTab;

            return fragment;
        }

        private void GetText()
        {
            var text = LocalStorageGetText.GetText(enumTab);

            text_textview.Text = text;
        }

        private void GetImages()
        {
            if (enumTab == (int)Helper.enumTab.SagradaFamilia)
            {
                #region Image 1
                button_image1.Visibility = ViewStates.Visible;
                button_image1.SetImageDrawable(Resources.GetDrawable(Resource.Drawable.SagradaFamiliaSmall));

                button_image1.Click += (sender, e) =>
                  {
                      FragmentTransaction transation = FragmentManager.BeginTransaction();
                      ImageDialogFragment dialog = new ImageDialogFragment(Helper.enumImages.SagradaFamilia);
                      dialog.Show(transation, "Dialog Fragment");
                  };
                #endregion

                button_image2.Visibility = ViewStates.Visible;
                button_image2.SetImageDrawable(Resources.GetDrawable(Resource.Drawable.SagradaFamiliaPathonSmall));

                button_image2.Click += (sender, e) =>
                {
                    FragmentTransaction transcation = FragmentManager.BeginTransaction();
                    ImageDialogFragment dialog = new ImageDialogFragment(Helper.enumImages.SagradaFamiliaPathon);
                    dialog.Show(transcation, "Dialog Fragment");
                };
            }
            else if (enumTab == (int)Helper.enumTab.KazaBatlo)
            {
                button_image1.Visibility = ViewStates.Gone;
                button_image2.Visibility = ViewStates.Gone;
            }
            else
            {
                button_image1.Visibility = ViewStates.Gone;
                button_image2.Visibility = ViewStates.Gone;
            }
        }
    }
}
