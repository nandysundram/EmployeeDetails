using System;

namespace EmployeeAspire
{ 
    class Program  // This is the class that contains Main Method
    { 
        public static void Main()// This is the main method.
        {

            EmployeeDetails employeeAspire = new EmployeeDetails();
            getEmployeeSalary Salary = new getEmployeeSalary();// creating a new object to access members of EmployeeDetails Class.
            Console.WriteLine(employeeAspire.getEmployeeID());
            Console.WriteLine(employeeAspire.getEmployeeName());
            Console.WriteLine(employeeAspire.getEmployeeDOB());
            Console.WriteLine(employeeAspire.getEmployeeDOJ());
            Console.WriteLine(employeeAspire.getEmployeeMobileNo());
            Console.WriteLine(employeeAspire.getEmployeeEmail());
            Salary.GetEmployeeSalary();
        }

    }
}