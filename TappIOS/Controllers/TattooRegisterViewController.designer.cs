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
	[Register ("TattooRegisterViewController")]
	partial class TattooRegisterViewController
	{
		[Outlet]
		UIKit.UITextField TattooDescriptionText { get; set; }

		[Outlet]
		UIKit.UITextField TattooLocationText { get; set; }

		[Outlet]
		UIKit.UITextField TattooReferencesText { get; set; }

		[Outlet]
		UIKit.UITextField TattooSizeText { get; set; }

		[Action ("btnContinue:")]
		partial void btnContinue (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (TattooSizeText != null) {
				TattooSizeText.Dispose ();
				TattooSizeText = null;
			}

			if (TattooLocationText != null) {
				TattooLocationText.Dispose ();
				TattooLocationText = null;
			}

			if (TattooDescriptionText != null) {
				TattooDescriptionText.Dispose ();
				TattooDescriptionText = null;
			}

			if (TattooReferencesText != null) {
				TattooReferencesText.Dispose ();
				TattooReferencesText = null;
			}
		}
	}
}
