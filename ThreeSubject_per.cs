using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   internal class ThreeSubject_per
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter marks of Physics");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks of Math");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of Chem");
            int chem = Convert.ToInt32(Console.ReadLine());
            int total = (phy + math + chem);
            float per = (total) / 3;
            Console.WriteLine( total);
            Console.WriteLine(per);
            if (per > 80)
            {
                Console.WriteLine("A");
            }
            else if (per > 70)
            {
                Console.WriteLine("B");
            }
            else if (per > 60)
            {
                Console.WriteLine("C");
            }
            else if (per > 50)
            {
                Console.WriteLine("D");
            }
            else { 
                Console.WriteLine("Fail");
            }
            
        }
    }
}
