using System;

namespace CSharpOverloadedOperatorConsoleApplication
{
    class Program
    {
        //EXERCISE:
        //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
        //1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

        static void Main(string[] args)
        {
            Employee employee = new Employee() { Id = 123 };
            Employee employeeTwo = new Employee() { Id = 456 };

            Console.WriteLine(Convert.ToString(employee == employeeTwo));
            Console.ReadLine();
        }

    }
}