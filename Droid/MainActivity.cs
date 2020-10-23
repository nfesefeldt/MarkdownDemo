using Android.App;
using Android.Widget;
using Android.Views;
using Android.Support.V7.Widget;
using Android.OS;
using MarkdownDemo.Droid.Recycler;
using System.Collections.Generic;

namespace MarkdownDemo.Droid
{
    [Activity(Label = "MarkdownDemo", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        RecyclerView _Recycler;
        BasicAdapter _Adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var list = new List<RecyclerItem>() {
                new RecyclerItem {
                    Title = "This is a normal string title",
                    Subtitle = "This is a normal string subtitle"
                },
                new RecyclerItem {
                    Title = "This is a normal string title",
                    Subtitle = "This is a normal string subtitle"
                },
                new RecyclerItem {
                    Title = "This is a normal string title",
                    Subtitle = "This is a normal string subtitle"
                }
            };

            this._Adapter = new BasicAdapter(list);
           
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            this._Recycler = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            this._Recycler.SetAdapter(this._Adapter);
            var layoutManager = new LinearLayoutManager(this);
            this._Recycler.SetLayoutManager(layoutManager);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.myButton);

            //button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}

