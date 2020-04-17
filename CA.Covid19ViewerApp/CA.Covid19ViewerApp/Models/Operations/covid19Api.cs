using CA.Covid19ViewerApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace CA.Covid19ViewerApp.Models.Operations
{
    public class covid19Api
    {
        public covid19Api()
        {

        }

        public worldTotal getWorldTotalCount()
        {
            string resultText = apiBaseOperation.readApiAddress(addressList.WorldTotalList);
            return resultText == null ?
            new worldTotal() { }
            : Newtonsoft.Json.JsonConvert.DeserializeObject<worldTotal>(resultText);
        }

        public summary getSummary()
        {
            string resultText = apiBaseOperation.readApiAddress(addressList.GetSummary);
            return resultText == null ?
           new summary() { }
           : Newtonsoft.Json.JsonConvert.DeserializeObject<summary>(resultText);
        }

        public List<countries> GetCountries()
        {
            string resultText = apiBaseOperation.readApiAddress(addressList.GetCountries);
            return resultText == null ?
          new List<countries>() { }
          : Newtonsoft.Json.JsonConvert.DeserializeObject<List<countries>>(resultText);
        }

        public List<cases> getCountryTotal(string countryName)
        {
            string resultText = apiBaseOperation.readApiAddress($"{addressList.GetCountryTotal}{countryName}");
            return resultText == null ?
        new List<cases>() { }
        : Newtonsoft.Json.JsonConvert.DeserializeObject<List<cases>>(resultText);

        }
    }
}