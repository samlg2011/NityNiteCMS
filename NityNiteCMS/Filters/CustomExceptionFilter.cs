using NityNiteCMS.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NityNiteCMS.Filters
{
    public class CustomExceptionFilter:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            FileLogger log = new FileLogger();
            log.LogExceptoin(filterContext.Exception);
            base.OnException(filterContext);
        }
    }
}