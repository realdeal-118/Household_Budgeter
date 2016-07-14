using System.Web;
using System.Web.Mvc;

namespace Household_Budgeter
{
    //This is the Filter Config file//
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
