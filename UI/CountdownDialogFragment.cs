using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Barcelona.UI
{
    public class CountdownDialogFragment : DialogFragment
    {
        TextView textview;

        public CountdownDialogFragment()
        {
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.CountdownDialogFragment, container, false);

            textview = view.FindViewById<TextView>(Resource.Id.textview_title);

            InitializeCountdownTimer();

            return view;
        }

        private void InitializeCountdownTimer()
        {
            DateTime travelDate = new DateTime(2019, 10, 24, 08, 0, 0);

            DateTime nowDate = new DateTime();
            nowDate = DateTime.Now;

            var t = travelDate - nowDate;

            textview.Text = string.Format("{0} Days, {1} Hours, {2} Minutes", t.Days, t.Hours, t.Minutes);
        }
    }
}
