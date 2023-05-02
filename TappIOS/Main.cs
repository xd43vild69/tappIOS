using UIKit;

namespace TappIOS
{
    public class Application
    {
        // This is the main entry point of the application.
        // feature/test2.7
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            // main v4
            UIApplication.Main(args, null, typeof(AppDelegate));
        }   
    }
}
