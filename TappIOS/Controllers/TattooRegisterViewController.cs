// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Diagnostics;

using Foundation;
using TappIOS.Domain.Customer;
using UIKit;

namespace TappIOS.Storyboards
{
	public partial class TattooRegisterViewController : UIViewController
	{
		public Customer Customer { get; set; }

		public TattooRegisterViewController (IntPtr handle) : base (handle)
		{
		}

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            Debug.Write($"String {Customer.Name}", "Click");
        }
    }
}