using CA.Covid19ViewerApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA.Covid19ViewerApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.Operations.covid19Api covid = new Models.Operations.covid19Api();
            worldTotal worldCovidData = covid.getWorldTotalCount();
            return View(worldCovidData);
        }

        public ActionResult Summary()
        {
            Models.Operations.covid19Api covid = new Models.Operations.covid19Api();
            summary summaryData = covid.getSummary();
            return View(summaryData);
        }

        public ActionResult ByCountry()
        {
            Models.Operations.covid19Api covid = new Models.Operations.covid19Api();
            List<countries> countryList = covid.GetCountries();
            return View(countryList.OrderBy(i => i.Country).ToList());
        }

        public PartialViewResult getCountryPartial(string countryName)
        {
            Models.Operations.covid19Api covid = new Models.Operations.covid19Api();
            List<cases> countryCaseDataList = covid.getCountryTotal(countryName);
            countryCaseDataList = countryCaseDataList.OrderBy(i => i.Date).ToList();
            return PartialView("partialCountryDetails", countryCaseDataList);
        }

        public JsonResult getCountryChart(string countryName)
        {
            countryChart chartJson = new countryChart();

            Models.Operations.covid19Api covid = new Models.Operations.covid19Api();
            List<cases> countryCaseDataList = covid.getCountryTotal(countryName);
            countryCaseDataList = countryCaseDataList.OrderBy(i => i.Date).ToList();
            countryCaseDataList.ForEach((cases c) =>
            {
                chartJson.dateString += $"'{c.Date.ToString("dd.MM.yyyy")}',";
                chartJson.dateValue += $"{c.Confirmed},";
            });
            chartJson.dateString = chartJson.dateString.Substring(0, chartJson.dateString.Length - 1);
            chartJson.dateValue = chartJson.dateValue.Substring(0, chartJson.dateValue.Length - 1);
            return Json(chartJson, JsonRequestBehavior.AllowGet);
        }
    }
}