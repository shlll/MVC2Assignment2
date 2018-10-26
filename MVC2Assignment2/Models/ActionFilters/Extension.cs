using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2Assignment2.Models.HtmlExtension
{
    public static class Extension
    {
        public static DateTime Age (this HtmlHelper helper, DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            birthday = new DateTime(1990, 01, 01);
            birthday = new DateTime(1987, 05, 07);
            birthday = new DateTime(1975, 10, 10);
            if (now < birthday.AddYears(age)) age--;
            return birthday.ToAge();
        }
        public static string digits()
        {
            string[] str = { "abc123", "z1x2c3v4", "#$ss223%^" };
            var result = str.ToDigitsOnly();
            foreach(var i in result)
            {
                Console.Write(i + "");
            }
            return digits;
        }
    }
}