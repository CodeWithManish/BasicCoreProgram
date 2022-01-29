using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter 1. to  print String Replace \n Enter 2. to print FlipCoin \n");
            bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        StringReplace sr = new StringReplace();
                        sr.Replace("Manish");
                        break;

                    case 2:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Flip();
                        break;
                }
            }

        }
    }
}
