using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final
{
    internal class CalculateGrossSalary
    {
  //10Write a Java program to input basic salary of an employee and calculate its //Gross salary
  //accordingto following: Basic Salary <= 10000 : HRA = 20%, DA = 80% Basic Salary <= 20000 : HRA = 25%, DA = 90% Basic Salary >20000 : HRA = 30%, DA = 95% 

        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Salary");
            double salary = Convert.ToSingle(Console.ReadLine());
            double  hra=0;
           double Da=0;
            if (salary < 10000)
            {
                hra = salary * 0.2;
                Da = salary * 0.80;
                
            }
             if (salary <= 20000)
            {
                hra = salary * 0.25;
                Da = salary * 0.90;
            }
            if(salary>2000)
            {
                hra = salary * 0.30;
                Da = salary * 0.95;
            }
            double Gross_salary = salary + hra + Da;
            Console.WriteLine("Gross Salary=:"+Gross_salary);
        }
    }
}

