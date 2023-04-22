using Foundation;
using System;
using UIKit;
using System.Threading.Tasks;
using TappIOS.Domain.User.Features;
using TappIOS.Domain.User;
using MediatR;
using TappIOS.Services;
using TappIOS.Domain.User.Services;
using TappIOS.Domain.Admin.Features;
using TappIOS.Domain.Admin.Services;
using TappIOS.Domain;
using TappIOS.Domain.Admin;

namespace TappIOS
{
    public partial class ViewController : UIViewController
    {

        private readonly IMediator _mediator;

        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public ViewController(IntPtr handle, IMediator mediator) : base(handle)
        {
            _mediator = mediator;
        }

        public override async void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            //TODO: Set user information from ServiceManager.SetName - SetConfigs - SetCalendar

            //TODO: Show Login Screen. CheckLogin - LoadSegttings - ShowMainMenu

            //TODO: Show main dashboard. 

            BaseEntity baseEntity = new User();

            baseEntity._bridge = new UserRepository2();
            baseEntity.GetData();


            baseEntity._bridge = new AdminRepository();
            baseEntity.GetData();

            baseEntity = new Admin();

            baseEntity._bridge = new UserRepository2();
            baseEntity.GetData();


            baseEntity._bridge = new AdminRepository();
            baseEntity.GetData();

            /*
            var c = new Services.ApiRepository();
            Task.Run(() => c.Connect());

            var s = new ServiceManager();
            var x = s.AdminLogged;
            var r = await ServiceManager.Login("xxx", "yyy");
            */

            //var user = new User();
            //var command = new UserExists.Command(user);
            //var response = await _mediator.Send(command);

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
