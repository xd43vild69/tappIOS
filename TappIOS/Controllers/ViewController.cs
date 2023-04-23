using Foundation;
using System;
using UIKit;
using System.Threading.Tasks;
using MediatR;
using TappIOS.Services;
using TappIOS.Domain.User.Services;
using TappIOS.Domain;
using TappIOS.Domain.User.ViewModel;

namespace TappIOS
{
    public partial class ViewController : UIViewController
    {
        public IUserViewModel userViewModel { get; }


        public ViewController (IntPtr handle) : base (handle)
        {
            userViewModel = ServiceManager._userViewModel;
        }

        //public ViewController(IntPtr handle, IMediator mediator) : base(handle)
        //{
        //    _mediator = mediator;
        //}

        public override async void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            //TODO: Set user information from ServiceManager.SetName - SetConfigs - SetCalendar

            //TODO: Show Login Screen. CheckLogin - LoadSegttings - ShowMainMenu

            //TODO: Show main dashboard. 
            
            var isLogged = await userViewModel.CheckUserLogin("d13", "d13");

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
