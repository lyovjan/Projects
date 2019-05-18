using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WhoIs.Models;
using WhoIs.Web.Helpers;
using Newtonsoft.Json;

namespace WhoIs.Web.Controllers
{
    public class HomeController : Controller
    {
       
        public async Task<IActionResult> Index()
        {
            UserIPAddress userIpAddress = new UserIPAddress();
            FullInfoModel fullInfo;
            string ip = await userIpAddress.GetUserIPAddressAsync();
            using (WebClient httpClient = new WebClient())
            {
                string jsonData = httpClient.DownloadString($"http://free.ipwhois.io/json/{ip}");
                fullInfo = JsonConvert.DeserializeObject<FullInfoModel>(jsonData);
               
            }

            return View(fullInfo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
