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
		public UIKit.UITextView label1 { get; set; }

		[Outlet]
		public UIKit.UITextView label2 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (label1 != null) {
				label1.Dispose ();
				label1 = null;
			}

			if (label2 != null) {
				label2.Dispose ();
				label2 = null;
			}
		}
	}
}
