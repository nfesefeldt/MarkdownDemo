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

        List<RecyclerItem> listItems;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            listItems = new List<RecyclerItem>() {
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

            this._Adapter = new BasicAdapter(listItems);
           
            SetContentView(Resource.Layout.Main);

            this._Recycler = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            this._Recycler.SetAdapter(this._Adapter);
            var layoutManager = new LinearLayoutManager(this);
            this._Recycler.SetLayoutManager(layoutManager);

            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate {
                ApplyMarkdown();
            };
        }

        void ApplyMarkdown()
        {
            listItems.Clear();
            listItems.Add(new RecyclerItem
            {
                Title = "Markdown String here",
                Subtitle = "And here"
            });

            listItems.Add(new RecyclerItem
            {
                Title = "Markdown String here",
                Subtitle = "And here"
            });

            listItems.Add(new RecyclerItem
            {
                Title = "Markdown String here",
                Subtitle = "And here"
            });

            this._Adapter.NotifyDataSetChanged();
        }
    }
}

