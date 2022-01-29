using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter the Number");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0 || (year % 400 == 0)))
            {
                Console.WriteLine("this is leap year");
            }
            else
            {
                Console.WriteLine("this is not a leap year");
            }
            Console.ReadLine();
        }
    }
}
