using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA.Covid19ViewerApp.Models.Entities
{
    public class summary
    {
        public summaryGlobal Global { get; set; }
        public List<summaryCountry> Countries { get; set; }
    }

    public class summaryGlobal
    {
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }

        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
    }

    public class summaryCountry
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        
        public int NewConfirmed { get; set; }
        public int  TotalConfirmed { get; set; }
        
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }

        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }

        public DateTime Date { get; set; }
    }
}