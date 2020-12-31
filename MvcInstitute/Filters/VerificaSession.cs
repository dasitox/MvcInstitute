using MvcInstitute.Controllers;
using System;
using System.Web;
using System.Web.Mvc;

namespace MvcInstitute.Filters
{
    public class VerificaSession : ActionFilterAttribute
    {
        private object oUser;

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            try
            {
                base.OnActionExecuted(filterContext);

                oUser = (object)HttpContext.Current.Session["User"];
                if (oUser == null)
                {
                    if (filterContext.Controller is HomeController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("~/Home/Index");
                    }
                }
            }
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("~/Home/Index");
            }
        }
    }
}