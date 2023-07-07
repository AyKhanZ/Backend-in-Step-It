namespace Proxy
{
    public class Program
    {
        public static void Main()
        {
            ISite site = new SiteProxy(new Site());
            Console.WriteLine(site.GetPage(1));
            Console.WriteLine(site.GetPage(2));
            Console.WriteLine(site.GetPage(3));
            Console.WriteLine(site.GetPage(45));
        }
    }

    
}