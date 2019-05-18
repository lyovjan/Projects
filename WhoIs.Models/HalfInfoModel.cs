using System;
using System.Collections.Generic;
using System.Text;

namespace WhoIs.Models
{
   public class HalfInfoModel
    {
        public string Ip { get; set; }
        public bool Success { get; set; }
        public string Type { get; set; }
        public string Continent { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string CountryFlag { get; set; }
        public string CountryCapital { get; set; }
        public string CountryPhone { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string TimezoneGmt { get; set; }
        public string Currency { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyPlural { get; set; }
    }
}
