namespace Proxy;
public class Site : ISite
{
    public string GetPage(int num) => "This is page " + num;
}