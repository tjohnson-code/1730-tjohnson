using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tjohnson3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };    
            
            string weekday = "";
            if (index >= 1 && index < 8)
            {
                weekday = days[index - 1];
                return weekday;            
            }
            return "Invalid index"; 


        }

        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };

            search = search.Trim();
            search = search.ToUpper();
            int index = Array.IndexOf(days, search);
            if (index >= 0 && index <= 6)
            {
                return hours[index];
            }
            return "Invalid input";
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int total in numbers)
                sum += total;

            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;
            int length = numbers.GetLength(0);
            if (count >= 0 && count <= length)
            {
                for (int i = 0; i < count; i++)
                    sum += numbers[i];
                return sum;
            }
            return 0.0;
            
        }
        public static double Calc5(double[] numbers)
        {
            int length = numbers.Length;
            if (length > 0)
            {
                double average = Calc3(numbers, length) / length;
                return average;
            }
            return -1;
            
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (double i in numbers)
                {
                    if (i >= avg)
                        aboveAvgList.Add(i);
                }
            }

            return aboveAvgList.ToArray();
        }
    }
}
