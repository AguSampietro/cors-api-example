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
                    AllowAnyMethod = true,
                    AllowAnyOrigin = true
                };

                policy.Origins.Add(originRequested);

                //IP ESPECIFICA
                //policy.Origins.Add("http://127.0.0.1:5500");
                //policy.Origins.Add("https://artecba-4dd88.web.app:443");
                //policy.Origins.Add("https://199.36.158.100:443");

                //policy.Origins.Add("http://artecba-4dd88.web.app:80");
                //policy.Origins.Add("http://199.36.158.100:80");

                policy.Origins.Add("https://cotillon.cl");
                policy.Origins.Add("https://cotillon.cl:80");
                policy.Origins.Add("https://cotillon.cl:433");
                policy.Origins.Add("https://rosas.cotillon.cl:443");
                policy.Origins.Add("https://200.54.174.58:443");

                //policy.Origins.Add("http://rosas.cotillon.cl:80");
                //policy.Origins.Add("http://200.54.174.58:80");

                //policy.Origins.Add("http://localhost:8888");
                //policy.Origins.Add("http://190.210.65.189");

                //policy.Origins.Add("https://artecba-4dd88.web.app:443");
                //policy.Origins.Add("https://artecba-4dd88.firebaseapp.com");
                //policy.Origins.Add("https://artecba.com:443");
                //policy.Origins.Add("http://artecba.com:80");
                //policy.Origins.Add("https://artecba.com");

                policy.Origins.Add("http://localhost:8000");
                policy.Origins.Add("https://atila.online/massioFlota/web");
                policy.Origins.Add("https://atila.online/massioFlota");
                policy.Origins.Add("https://atila.online");
                policy.Origins.Add("https://atila.online:80");
                policy.Origins.Add("https://atila.online:433");
                policy.Origins.Add("200.122.90.11");
                policy.Origins.Add("200.122.90.11:433");
                policy.Origins.Add("200.122.90.11:80");
                policy.Origins.Add("192.168.2.123:3389");

                policy.Origins.Add("http://oficinavirtual.cooperativasudeste.com.ar:9327");

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