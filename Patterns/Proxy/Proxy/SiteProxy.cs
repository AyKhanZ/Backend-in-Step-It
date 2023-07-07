namespace Proxy;
class SiteProxy : ISite
{
    private ISite Site;
    private Dictionary<int, string> Cache;
    public SiteProxy(ISite site)
    {
        this.Site = site;
        Cache = new Dictionary<int, string>();
    }

    public string GetPage(int num)
    {
        string page;
        if (Cache.ContainsKey(num))
        {
            page = Cache[num];
            page = "From cache" + page;
        }
        else
        {
            page = Site.GetPage(num);
            Cache.Add(num, page);
        }
        return page;
    }
}

