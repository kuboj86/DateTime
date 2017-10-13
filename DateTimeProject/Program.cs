using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Identifying the two variables for our DateTime type aswell as prompting
            // the user the format in which to enter in the dates.
            DateTime dateOne = getDate("Please enter a date using the format \"mm-dd-yyyy\": ");
            DateTime dateTwo = getDate("Please enter another date using the format \"mm-dd-yyyy\": ");
            
            //ThirdDate variable created from subtracting dateOne and dateTwo
            TimeSpan thirdDate = dateOne.Subtract(dateTwo);
            //Once the dates are entered, the result will show the difference of the two dates
            //In days, hours, and minutes.
            Console.WriteLine("Days = " + positiveOutput(thirdDate.TotalDays) + ", Hours = " +
                positiveOutput(thirdDate.TotalHours) + ", Minutes = " + positiveOutput(thirdDate.TotalMinutes));
            Console.ReadLine();
        }

        private static double positiveOutput(double number)
        {
            return Math.Abs(number);
        }

            // Using resursive method to ensure a date is entered using DateTime type 
            // If anything but numbers are entered or they are not in the correct format
            // User will be prompted to try again
        private static DateTime getDate(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            DateTime date;
             if (DateTime.TryParse(input, out date))
             {
                return date;
             }
            else
            {
                return getDate("please enter a valid date using the format \"mm-dd-yyyy\": ");
            }

        }
    }
}
