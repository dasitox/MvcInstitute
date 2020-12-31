using System;
using System.Web.Mvc;

namespace MvcInstitute.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class AuthotizeUser : AuthorizeAttribute
    {
        

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            try
            {  
            }
            catch (Exception)
            {
                
            }
        }
    }
}