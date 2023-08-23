using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Switch_Day
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Enter Zero For sunday");
            Console.WriteLine( "Enter One for Monday");
            Console.WriteLine( "Enter Two For Tuesday");
            Console.WriteLine( "Enter Three For Wednesday");
            Console.WriteLine( "Enter Four For Thursday");
            Console.WriteLine( "Enter Five for Friday");
            Console.WriteLine("Enter six For Saturday");
            Console.WriteLine("Enter Your Choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 0:
                    {
                        Console.WriteLine("Its Sunday");
                        break;
                    }
                case 1: 
                    {
                        Console.WriteLine( " Its Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine( "Its Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Its Wednesday" );
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Its Thursdy");
                            break;
                    }
                case 5:
                    {
                        Console.WriteLine( "Its Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine( "Its Saturday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter Valid Number");
                         break;
                    }
            }

        }
    }
}
