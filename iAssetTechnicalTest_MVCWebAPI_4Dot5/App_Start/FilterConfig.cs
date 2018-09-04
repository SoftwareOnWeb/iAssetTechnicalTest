using System.Web;
using System.Web.Mvc;

namespace iAssetTechnicalTest_MVCWebAPI_4Dot5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
