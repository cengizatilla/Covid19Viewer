using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA.Covid19ViewerApp.Models.Entities
{
    public class cases
    {
        public string Country { get; set; }
        public string Confirmed { get; set; }
        public string Deaths { get; set; }
        public string Recovered { get; set; }
        public DateTime Date { get; set; }
    }
}