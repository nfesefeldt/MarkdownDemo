// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MarkdownDemo.iOS
{
	partial class CustomCell
	{
		[Outlet]
		UIKit.UITextView firstLabel { get; set; }

		[Outlet]
		UIKit.UITextView secondLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (firstLabel != null) {
				firstLabel.Dispose ();
				firstLabel = null;
			}

			if (secondLabel != null) {
				secondLabel.Dispose ();
				secondLabel = null;
			}
		}
	}
}
