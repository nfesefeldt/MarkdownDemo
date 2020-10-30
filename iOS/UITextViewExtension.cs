using System;
using UIKit;
using Markdig.Renderers;
using Foundation;
using System.Text;

namespace MarkdownDemo.iOS
{
    public static class TextViewExtension
    {
        public static void ApplyMarkdown(this UITextView textView, string value)
        {
            var htmlString = Markdig.Markdown.ToHtml(value);

            var bytes = UTF8Encoding.Default.GetBytes(htmlString);
            var utf8String = UTF8Encoding.Default.GetString(bytes);
            var data = NSData.FromString(utf8String);
            var error = new NSError();

            var options = new NSAttributedStringDocumentAttributes();
            options.DocumentType = NSDocumentType.HTML;
            options.StringEncoding = NSStringEncoding.UTF8;
            textView.AttributedText = new NSAttributedString(data, options, ref error);
        }
    }
}