using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class EvenOdd
    {
        public void EvenOddNum()
        {
            Console.WriteLine("Enter the Number ");
            int Num=Convert.ToInt32(Console.ReadLine());

            if (Num % 2 == 0)
            {
                Console.WriteLine("Even number \n", Num);
            }
            else
            {
                Console.WriteLine("Odd Number \n ", Num);
            }
        }
    }
}
