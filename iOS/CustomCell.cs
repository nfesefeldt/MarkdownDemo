using System;

using Foundation;
using UIKit;

namespace MarkdownDemo.iOS
{
    [Register("CustomCell")]
    public partial class CustomCell : UITableViewCell {

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        protected CustomCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
