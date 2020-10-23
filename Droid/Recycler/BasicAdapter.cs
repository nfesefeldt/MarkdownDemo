using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;

namespace MarkdownDemo.Droid.Recycler
{
    public class BasicAdapter : RecyclerView.Adapter
    {
        List<RecyclerItem> _Items;

        public BasicAdapter(List<RecyclerItem> items)
        {
            this._Items = items;
        }

        public override int ItemCount => this._Items.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var item = this._Items[position];

            if (holder is RecyclerViewHolder viewHolder)
            {
                viewHolder.Bind(item);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var row = inflater.Inflate(Resource.Layout.RecyclerViewHolder, parent, false);
            return new RecyclerViewHolder(row);
        }
    }
}
