using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Barcelona.LocalStorageHandler;
using ClToolbar = Android.Support.V7.Widget.Toolbar;
using Uri = Android.Net.Uri;

namespace Barcelona
{
    [Activity(Label = "TabActivity")]
    public class TabActivity : Activity
    {
        string title;
        int enumTab;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TabActivity);

            enumTab = Intent.GetIntExtra("enumTab", -1);
            title = Intent.GetStringExtra("title");

            TabFragment DetailFragment = TabFragment.NewInstance(enumTab);

            var fragmentTx = FragmentManager.BeginTransaction();
            fragmentTx.Replace(Resource.Id.framelayout_tabfragment, DetailFragment);
            fragmentTx.Commit();

            this.ActionBar.Title = title;
        }

        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            var MenuActions = new List<MenuAction> 
            {
                new MenuAction() { Id=100, Text="Ticket", ShowAsAction=ShowAsAction.IfRoom, Order=1, Icon=Resource.Drawable.ticket, Action = () => { Tickets();}},
                new MenuAction() { Id=101, Text="Map", ShowAsAction=ShowAsAction.IfRoom, Order=1, Icon=Resource.Drawable.maps, Action = () => { DisplayMap();}}
            };

            BnftMenu.AddCustomMenuActions(MenuActions, menu);

            return base.OnPrepareOptionsMenu(menu);
        }

        private void Tickets()
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            TicketsDialogFragment dialog = new TicketsDialogFragment((Helper.enumTab)enumTab);
            dialog.Show(transaction, "Tickets");
        }

        private void DisplayMap()
        {
            var query = LocalStorageGetText.GetPosition(enumTab);

            Uri gmmIntentUri = Uri.Parse(query);
            Intent mapIntent = new Intent(Intent.ActionView, gmmIntentUri);
            mapIntent.SetPackage("com.google.android.apps.maps");
            StartActivity(mapIntent);
        }
    }

    #region Helpersr
    public class MenuAction
    {
        public int Id { set; get; }
        public int GroupId { set; get; }
        public int Order { set; get; }
        public string Text { set; get; }
        public int Icon { set; get; }
        public ShowAsAction ShowAsAction { set; get; }
        public Action Action { set; get; }
    }

    public static class BnftMenu
    {
        public static void AddCustomMenuActions(List<MenuAction> menuActions, IMenu menu)
        {
            if (menuActions != null && menu != null)
            {
                foreach (MenuAction menuAction in menuActions)
                {
                    if (menu.FindItem(menuAction.Id) == null)
                    {
                        IMenuItem menuItem = menu.Add( menuAction.GroupId, menuAction.Id, menuAction.Order, menuAction.Text);
                        menuItem.SetIcon(menuAction.Icon);
                        menuItem.SetShowAsActionFlags(menuAction.ShowAsAction);

                        ClickListener clickListener = new ClickListener(menuAction.Action);
                        menuItem.SetOnMenuItemClickListener(clickListener);
                    }
                }
            }
        }
    }

    class ClickListener : Java.Lang.Object, IMenuItemOnMenuItemClickListener
    {
        Action _action;

        public ClickListener(Action action) : base() { _action = action; }

        public bool OnMenuItemClick(IMenuItem item)
        {
            _action();
            return true;
        }
    }
    #endregion
}