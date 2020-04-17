using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA.Covid19ViewerApp.Models.Entities
{
    public class worldTotal
    {
        public int TotalConfirmed { get; set; }
        public int TotalDeaths { get; set; }
        public int TotalRecovered { get; set; }
    }
}