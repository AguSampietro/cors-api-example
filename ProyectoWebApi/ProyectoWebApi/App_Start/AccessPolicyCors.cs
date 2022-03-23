using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace ProyectoWebApi.App_Start
{
    public class AccessPolicyCors : Attribute, ICorsPolicyProvider
    {

        public async Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var corsRequestContext = request.GetCorsRequestContext();
            var originRequested = corsRequestContext.Origin;

            if (await IsOriginFromCustomer(originRequested))
            {
                var policy = new CorsPolicy
                {
                    AllowAnyHeader = true,
                    AllowAnyMethod = true
                };

                policy.Origins.Add(originRequested);

                //IP ESPECIFICA
                policy.Origins.Add("http://127.0.0.1:5500");
                policy.Origins.Add("https://artecba-4dd88.web.app:443");
                policy.Origins.Add("https://199.36.158.100:443");

                policy.Origins.Add("http://artecba-4dd88.web.app:80");
                policy.Origins.Add("http://199.36.158.100:80");

                return policy;
            }
            return null;
        }

        private async Task<bool> IsOriginFromCustomer(string originRequested)
        {
            return true;
        }
    }
}