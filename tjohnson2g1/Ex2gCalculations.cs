using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tjohnson2g1
{
    public class Ex2gCalculations
    {
        public static string Switch01(string customerType)
        {
            // 1A) 'Switch' with no default
            decimal discountPercent = -1m;

            switch(customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
            }

            return discountPercent.ToString("0.0"); 
        }
        public static string If01(string customerType)
        {
            // 1B) Separate 'if' statements
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;
            return discountPercent.ToString("0.0");
        }
        public static string ElseIf01(string customerType)
        {
            // 1C) If elseif
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;
            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElse01(string customerType)
        {
            // 1D) Nested if-else
            decimal discountPercent = -1m;

            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
            }                
            return discountPercent.ToString("0.0");
        }
        public static string SwitchDefault01(string customerType)
        {
            // 1E) 'Switch' with default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
                default:
                    discountPercent = 0m;
                    break;
            }

            return discountPercent.ToString("0.0");
        }
        public static string IfDefault01(string customerType)
        {
            // 1F) Separate 'if' statements with default
            decimal discountPercent = -1m;
            
            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;
            if (customerType != "R" && customerType != "C")
                discountPercent = 0m;
            return discountPercent.ToString("0.0");
        }
        public static string ElseIfDefault01(string customerType)
        {
            // 1G) If elseif with default
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;
            else
                discountPercent = .0m;
            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElseDefault01(string customerType)
        {
            // 1H) Nested if-else with default
            decimal discountPercent = -1m;

            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
                
                else
                {
                    discountPercent = 0m;
                }
            }
            return discountPercent.ToString("0.0");
        }
        public static string Switch02(string customerType)
        {
            // 2A) 'Switch' with no default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                case "C":
                    discountPercent = .2m;
                    break;
                case "T":
                    discountPercent = .4m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }
        public static string If02(string customerType)
        {
            // 2B) Separate 'if' statements
            decimal discountPercent = -1m;

            if (customerType == "R" || customerType == "C")
                discountPercent = .2m;
            if (customerType == "T")
                discountPercent = .4m;            
            return discountPercent.ToString("0.0");
        }
        public static string ElseIf02(string customerType)
        {
            // 2C) if elseif without default
            decimal discountPercent = -1m;

            if (customerType == "R" || customerType == "C")
                discountPercent = .2m;
            else if (customerType == "T")
                discountPercent = .4m;
            return discountPercent.ToString("0.0");

        }
        public static string NestedIfElse02(string customerType)
        {
            // 2D) Nested if-else without default
            decimal discountPercent = -1m;
            if (customerType == "R" || customerType == "C")
            {
                discountPercent = .2m;
            }
            else
            {
                if (customerType == "T")
                {
                    discountPercent = .4m;
                }                
            }
            return discountPercent.ToString("0.0");
        }
    }
}
