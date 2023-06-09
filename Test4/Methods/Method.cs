using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Test4.Method
{
    public static class Method
    {
        public static string GetShamsiDate(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();


            string Year = pc.GetYear(date).ToString();
            string Month = pc.GetMonth(date).ToString();
            string Day = pc.GetDayOfMonth(date).ToString();

            return $"{Year}/{Month}/{Day}";
        }
    }
}