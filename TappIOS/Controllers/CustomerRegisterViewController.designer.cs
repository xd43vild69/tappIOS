// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TappIOS.Storyboards
{
	[Register ("CustomerRegisterViewController")]
	partial class CustomerRegisterViewController
	{
		[Outlet]
		UIKit.UITextField CustomerCellphoneText { get; set; }

		[Outlet]
		UIKit.UITextField CustomerEmailText { get; set; }

		[Outlet]
		UIKit.UITextField CustomerInstagramText { get; set; }

		[Outlet]
		UIKit.UITextField CustomerNameText { get; set; }

		[Action ("btnContinue:")]
		partial void btnContinue (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CustomerNameText != null) {
				CustomerNameText.Dispose ();
				CustomerNameText = null;
			}

			if (CustomerCellphoneText != null) {
				CustomerCellphoneText.Dispose ();
				CustomerCellphoneText = null;
			}

			if (CustomerEmailText != null) {
				CustomerEmailText.Dispose ();
				CustomerEmailText = null;
			}

			if (CustomerInstagramText != null) {
				CustomerInstagramText.Dispose ();
				CustomerInstagramText = null;
			}
		}
	}
}
