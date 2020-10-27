using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace MarkdownDemo.Droid.Recycler
{
    public class RecyclerViewHolder: RecyclerView.ViewHolder
    {
        public TextView Title;
        public TextView Subtitle;

        public RecyclerViewHolder(View itemView) : base(itemView)
        {
            Title = itemView.FindViewById<TextView>(Resource.Id.row_title);
            Subtitle = itemView.FindViewById<TextView>(Resource.Id.row_subtitle);
        }

        public void Bind(RecyclerItem item)
        {
            this.Title.ApplyMarkdown(item.Title);
            this.Subtitle.ApplyMarkdown(item.Subtitle);
        }
    }
}
