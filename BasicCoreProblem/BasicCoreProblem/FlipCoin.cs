using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class FlipCoin
    {
        int tails = 0, heads = 0, i = 0;
        float num = 0;
        Random random = new Random();
        public void Flip()
        {
            Console.WriteLine("Enter the number of times to Coin Flip ");
            int a = Convert.ToInt32(Console.ReadLine());
            while (i < a)
            {
                i++;
                num = random.Next(2);
                if (num > 0)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }
            Console.WriteLine("Percentage of Tails : " + (tails * 100) / a + "%");
            Console.WriteLine("Percentage of Heads : " + (heads * 100) / a + "%");
            Console.ReadKey();

        }
    }
}
