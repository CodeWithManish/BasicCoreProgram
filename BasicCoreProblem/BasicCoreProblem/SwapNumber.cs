using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class SwapNumber
    {
        public void Swap()
        {
            int i = 10;
            int j = 20;
            i = i + j;
            j = i-j;
            i = i-j;

            Console.WriteLine("i = "+i );
            Console.WriteLine("j = "+j ); 
            
        }
    }
}
