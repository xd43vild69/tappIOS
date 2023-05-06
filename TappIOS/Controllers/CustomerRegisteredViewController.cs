// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Diagnostics;
using Foundation;
using UIKit;
using TappIOS.Domain.Customer;

namespace TappIOS.Storyboards
{
    public partial class CustomerRegisteredViewController : UIViewController
    {
        public Customer Customer { get; set; }

        public CustomerRegisteredViewController(IntPtr handle) : base(handle)
        {

        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            Debug.Write($"String {Customer.Name}", "DidLoad");
            //TODO: check if everything is ok then save
            //TODO: Or show message error
        }
    }
}