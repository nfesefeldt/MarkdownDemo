using System;
using Android.Text;
using Android.Widget;

namespace MarkdownDemo.Droid
{
    public static class TextViewExtension
    {
        public static void ApplyMarkdown(this TextView textView, string value)
        {
            var htmlString = Markdig.Markdown.ToHtml(value);
            textView.TextFormatted = Html.FromHtml(htmlString);
        }
    }
}
