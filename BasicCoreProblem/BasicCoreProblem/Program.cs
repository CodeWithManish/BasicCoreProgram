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

            Console.WriteLine(" Enter 1. to  print String Replace \n Enter 2. to print FlipCoin \n" +
                " Enter 3. to print Leap Year \n Enter 4. to print Power of two \n Enter 5. to print harmonic number \n " +
                "Enter 6. to print prime factor \n Enter 7. to find Swap Number \n" +
                " Enter 8. to check Even Odd Number \n Enter 9. to find Quotient and Remainder value \n Enter 10. to find Largest among tree Number \n");

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

                    case 3:
                        LeapYear leapYear = new LeapYear();
                        leapYear.Leap();
                        break;

                    case 4:
                        PowerOfTwo powerOfTwo = new PowerOfTwo();
                        powerOfTwo.CheckPower();
                        break;

                    case 5:
                        Harmonic harmonic = new Harmonic();
                        harmonic.HarmonicNum();
                        break;

                    case 6:
                        PrimeFactor primeFactor = new PrimeFactor();
                        primeFactor.Factor();
                        break;

                    case 7:
                        SwapNumber swapNumber = new SwapNumber();
                        swapNumber.Swap();
                        break;

                    case 8:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.EvenOddNum();
                        break;

                    case 9:
                        QuotientAndRemainder qr = new QuotientAndRemainder();
                        qr.QuotientRemainder();
                        break;

                    case 10:
                        LargeNumber largeNumber = new LargeNumber();
                        largeNumber.Biggest();
                        break;

                    
                }
            }

        }
    }
}
