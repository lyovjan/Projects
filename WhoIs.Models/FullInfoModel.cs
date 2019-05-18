using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WhoIs.Models
{
    public class FullInfoModel
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("continent_code")]
        public string ContinentCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_flag")]
        public Uri CountryFlag { get; set; }

        [JsonProperty("country_capital")]
        public string CountryCapital { get; set; }

        [JsonProperty("country_phone")]
        public string CountryPhone { get; set; }

        [JsonProperty("country_neighbours")]
        public string CountryNeighbours { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("asn")]
        public string Asn { get; set; }

        [JsonProperty("org")]
        public string Org { get; set; }

        [JsonProperty("isp")]
        public string Isp { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_name")]
        public string TimezoneName { get; set; }

        [JsonProperty("timezone_dstOffset")]
        public long TimezoneDstOffset { get; set; }

        [JsonProperty("timezone_gmtOffset")]
        public long TimezoneGmtOffset { get; set; }

        [JsonProperty("timezone_gmt")]
        public string TimezoneGmt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("currency_rates")]
        public string CurrencyRates { get; set; }

        [JsonProperty("currency_plural")]
        public string CurrencyPlural { get; set; }
    }
}
