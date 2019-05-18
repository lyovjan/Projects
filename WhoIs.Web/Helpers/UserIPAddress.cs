using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WhoIs.Web.Helpers
{
    public class UserIPAddress
    {
        public async Task<string> GetUserIPAddressAsync()
        {
            var httpClient = new HttpClient();
            var ip = await httpClient.GetStringAsync("https://api.ipify.org");
            return ip;
        }
    }
}