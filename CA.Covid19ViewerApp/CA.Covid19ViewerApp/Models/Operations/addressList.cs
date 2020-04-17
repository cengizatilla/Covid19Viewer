using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA.Covid19ViewerApp.Models.Operations
{
    public static class addressList
    {
        public static string WorldTotalList = "https://api.covid19api.com/world/total";
        public static string GetSummary = "https://api.covid19api.com/summary";
        public static string GetCountries = "https://api.covid19api.com/countries";
        public static string GetCountryTotal = "https://api.covid19api.com/total/country/";
    }
}