﻿using System.Web;
using System.Web.Mvc;

namespace Cloud_WebApplication_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
