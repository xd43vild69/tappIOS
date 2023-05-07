// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Diagnostics;
using Foundation;
using TappIOS.Domain.Customer;
using UIKit;

namespace TappIOS.Storyboards
{
	public partial class CustomerRegisterViewController : UIViewController
	{
		public CustomerRegisterViewController(IntPtr handle) : base(handle)
		{
		}

		public override async void ViewDidLoad()
		{
			base.ViewDidLoad();
            Debug.Write($"{nameof(ViewDidLoad)}", "CustomerRegisterVC");
        }

        partial void btnContinue(Foundation.NSObject sender)
		{

            Debug.Write($"Method name {nameof(btnContinue)}", "Click");

            TattooRegisterViewController tattooRegisterVC = this.Storyboard.InstantiateViewController("TattooRegisterViewController") as TattooRegisterViewController;
            if (tattooRegisterVC != null)
            {
                var customer = new Customer()
                {
                    Name = CustomerNameText.Text,
                    Cellphone = CustomerCellphoneText.Text,
                    Email = CustomerEmailText.Text,
                    InstagramUser = CustomerInstagramText.Text                    
                };

                tattooRegisterVC.Customer = customer;

                this.NavigationController.PushViewController(tattooRegisterVC, true);
            }
        }
    }
}
