﻿using Android.App;
using Android.Widget;
using Android.Views;
using Android.Support.V7.Widget;
using Android.OS;
using MarkdownDemo.Droid.Recycler;
using System.Collections.Generic;
using Android.Text;

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
                Title = "This is a text with some *emphasis*",
                Subtitle = "Subtitle"
            });

            listItems.Add(new RecyclerItem
            {
                Title = "This is a block of text that **includes** the __features__ we are *likely* to _want_, and omits the ones we do not want.",
                Subtitle = "Subtitle"
            });

            listItems.Add(new RecyclerItem
            {
                Title = "This is a string with some **bold stuff**",
                Subtitle = "Subtitle"
            });

            this._Adapter.NotifyDataSetChanged();
        }
    }
}

