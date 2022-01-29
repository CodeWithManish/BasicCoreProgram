using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    public class VowelAndConsonent
    {
        public void Alphabet()
        {

            Console.WriteLine("Enter any Character: ");
            string value = Console.ReadLine();
            value = value.ToLower();
            string vowel = "";
            string consonent = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == 'a' || value[i] == 'e' || value[i] == 'i' || value[i] == 'o' || value[i] == 'u')
                {
                    vowel += value[i];
                }
                else
                {
                    consonent += value[i];
                }
            }
           
            Console.WriteLine("Vowels in the String : "+vowel);
            Console.WriteLine("Consonent in the String : " + consonent);
            Console.ReadLine();
        }
    }
}
