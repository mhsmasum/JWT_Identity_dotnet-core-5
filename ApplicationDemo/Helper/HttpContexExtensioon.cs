using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Helper
{
    public static class HttpContexExtensioon
    {
        public static string GetUserId(this HttpContext httpContext)
        {
            string result = string.Empty;
            try
            {
                if (httpContext.User != null)
                {
                    result = httpContext.User.Claims
                        .SingleOrDefault(s => s.Type.ToString().Equals("userid", StringComparison.InvariantCultureIgnoreCase))
                        .Value;
                }
            }
            catch (Exception ex)
            {

                // throw;               
                result = string.Empty;
            }
            return result;
        }
    }
}
