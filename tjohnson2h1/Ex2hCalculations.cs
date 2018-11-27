using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace tjohnson2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
            
            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime date1, date2;
            try
            {
                date1 = DateTime.Parse(strDateA);
                date2 = DateTime.Parse(strDateB);
                TimeSpan date = date1 - date2;
                int days = date.Days;
                result = days.ToString() + " days";
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime date1, date2;  // date1 = date paid, date2 = date due
            try
            {
                date1 = DateTime.Parse(strDateA);
                date2 = DateTime.Parse(strDateB);
                TimeSpan date = date1 - date2;  // date paid - date due
                int days = date.Days;

                if (date1 > date2) // if date paid is after due date
                    result = days.ToString() + " days past due";
                else
                    result = "On time";  // if date paid is before due date
            }
            catch { }

            return result;
        }
        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            try
            {
                int index1 = s.IndexOf("");
                s = s.Trim();
                s = s.Remove(0, index1 +1);
                s = s.Insert(0, "cr");
                result = s.ToString();
            }
            catch { }

            return result;
        }
        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            try
            {
                if (s.Length >= 2)
                {
                    int index1 = s.IndexOf("");
                    s = s.Trim();
                    s = s.Remove(1, index1 +1);
                    s = s.Insert(1, "rit");
                    result = s.ToString();
                }
            }
            catch { }

            return result;
        }
        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            try
            {
                int index1 = s.IndexOf("");
                s = s.Trim();
                string fourLetters = s.Substring(2, 4).ToUpper();
                s = fourLetters;
                result = s.ToString();
            }
            catch { }

            return result;
        }
        public static string StringCalc04(string s)
        {
            string result = "Invalid input";
            try
            {
                int index1 = s.IndexOf("");
                s = s.Trim();
                s = s.PadLeft(10, '*');
                result = s.ToString();
            }
            catch { }

            return result;
        }
        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            try
            {
                int index1 = s.IndexOf("");
                s = s.Trim();
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace(" ", "");
                s = s.Replace("-", "");
                result = s.ToString();
            }
            catch { }

            return result;
        }
        public static string StringCalc06(string s)
        {
            string result = "Invalid input";
            int index1 = s.IndexOf("");

            s = s.Trim();
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace(" ", "");
            s = s.Replace("-", "");

            if (s.Length == 10)
            {
                s = s.Insert(3, ".");
                s = s.Insert(7, ".");
                result = s.ToString();
            }

            else if (s.Length == 7)
            {
                s = s.Insert(3, ".");
                result = s.ToString();
            }

            else return result;


            return result;
        }
        public static string StringCalc07(string s)
        {
            string result = "Not found";
            string x = "pioneer";

            s = s.ToLower();

            if (s.Contains(x))
                result = "Found";

            return result;
        }
        public static string StringCalc08(string s)
        {
            string result = "Invalid input";

            s = s.Trim();
            int comma = s.IndexOf(",");
            string city = "";

            if (comma == -1)
                return result;

            else
                city = s.Substring(comma);
            city = city.Remove(0, +2);
            result = city.ToString();
            return result;
        }
        public static string StringCalc09(string s)
        {
            string result = "Invalid input";

            s = s.Trim();
            int zip = s.LastIndexOf(" ");

            if (zip == -1)
                return result;

            else
                s = s.Remove(0, zip + 1);
            result = s.ToString();

            return result;
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {            
            string result = "Invalid input";
            StringBuilder sb = new StringBuilder(100);
            try
            {
                sb.Append(s1 + ", " + s2 + ", " + s3);
                result = sb.ToString();
            }
            catch { }

            return result;
        }
    }
}