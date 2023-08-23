using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
  public class OverLoading
    {
        int r;
        double pi;
        int length;
        int breadth;
        int square;
        int Base;
        int Height;

        public void Area(double pi, int r)
        {
            double area = pi * r * r;
            Console.WriteLine( area);
        }
        public void Area(int length,int breadth)
        {
            int area=length* breadth;
            Console.WriteLine( area);
        }
        public void Area(int square)
        {
            int area=square*square;
            Console.WriteLine( area);

        }
        public void Area(float Base, int Height)
        {
            float area = Base * Height;
            Console.WriteLine( area);
        }
    }
    public class Obj
    {
        static void Main(string[] args)
        {
            OverLoading o1 = new OverLoading();
            o1.Area(2, 2);
        }
    }
}
