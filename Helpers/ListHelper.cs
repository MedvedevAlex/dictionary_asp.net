using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDictionary.Helpers
{
    public static class ListHelper
    {
        public static MvcHtmlString CreateList(this HtmlHelper html, IEnumerable<WebDictionary.Models.Driver> model)
        {
            TagBuilder tbody = new TagBuilder("tbody");

            foreach (var driver in model)
            {
                TagBuilder tr = new TagBuilder("tr");
                tr.InnerHtml += GetColumn(driver.Name);
                tr.InnerHtml += GetColumn(driver.LastName);
                tr.InnerHtml += GetColumn(driver.ExperienceDriveYear.ToString());
                tr.InnerHtml += GetColumn(driver.Car.Name);
                tr.InnerHtml += GetColumn(driver.Car.EngineLiter.ToString());
                tr.InnerHtml += GetColumn(driver.Car.Power.ToString());
                tr.InnerHtml += GetColumn(driver.Car.Transmission);
                tr.InnerHtml += GetColumn(driver.Car.Color);
                tbody.InnerHtml += tr.ToString();
            }
            return new MvcHtmlString(tbody.ToString());
        }
        private static string GetColumn(string property)
        {
            TagBuilder td = new TagBuilder("td");
            td.InnerHtml = property;
            return td.ToString();
        }
    }
}