using BxlForm.DemoSecurity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BxlForm.DemoSecurity.Areas.Admin.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AdminRequiredAttribute : TypeFilterAttribute
    {
        public AdminRequiredAttribute() : base(typeof(AuthRequiredFilter))
        {
        }

        private class AuthRequiredFilter : IAuthorizationFilter
        {
            public void OnAuthorization(AuthorizationFilterContext context)
            {
                ISessionManager sessionManager = (ISessionManager)context.HttpContext.RequestServices.GetService(typeof(ISessionManager));

                if (sessionManager.User is null || !sessionManager.User.IsAdmin)
                {
                    context.Result = new NotFoundResult();
                }
            }
        }
    }
}
