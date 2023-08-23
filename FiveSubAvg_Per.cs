using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   internal class FiveSubAvg_Per
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Marks of phy");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Enter Marks of Math");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of Chem");
            int chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Enter Marks of Bio");
            int bio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks Of java");
            int java = Convert.ToInt32(Console.ReadLine());
            int total = (phy + math + chem + bio + java);
            float avg = (float)total / 5;
            double per = (double)total/ 500*100;
            Console.WriteLine( total+"\n"+per+"\n"+avg);



        }
    }
}
