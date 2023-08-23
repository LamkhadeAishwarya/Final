using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
   internal class AvoidNumber
    {
        static void Main(string[] args)
        {
            int i = 1;
           
            for ( i = 1; i <= 20; i ++)
            {
           

                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine( i);
                }
            }
         
            
        
            
        }
    }
}
