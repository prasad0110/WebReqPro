using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebReqPro
{
    class GetUrlResponse : WebClient
    {
        private readonly CookieContainer _Container = new CookieContainer();

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            HttpWebRequest webRequest = request as HttpWebRequest;
            if (webRequest != null)
            {
                webRequest.CookieContainer = _Container;
            }
            return request;
        }

        public WebRequest MyGetWebRequest(Uri address)
        {
            return GetWebRequest(address);
        }
    }

}
