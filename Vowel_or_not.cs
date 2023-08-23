using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   internal class Vowel_or_not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            int ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("It Is Vowel" + ch);
            }
            else
            {
                Console.WriteLine("Not Vowel"+ch);
            }
            
           
            
        }
    }
}
