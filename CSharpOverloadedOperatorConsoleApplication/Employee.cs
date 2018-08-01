using System;

namespace CSharpOverloadedOperatorConsoleApplication
{
    class Employee
    {
        //EXERCISE:
        //IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
        //1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.


        public int Id { get; set; }


        public static bool operator ==(Employee employee, Employee employeeTwo)
        {
            if (employee.Id == employeeTwo.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employeeTwo)
        {
            if (employee.Id == employeeTwo.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}