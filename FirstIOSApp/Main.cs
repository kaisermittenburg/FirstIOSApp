using UIKit;

namespace FirstIOSApp
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            System.Console.WriteLine("Hello World");
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
