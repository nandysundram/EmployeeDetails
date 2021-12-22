using System;
namespace EmployeeAspire
{
    class getEmployeeSalary 
    {
    public double GetEmployeeSalary()
    {
        int bSalary;
        double hra, da, pf, gSalary;
        Console.WriteLine("Enter your basic Salary in Rupees: ");
        bSalary = Convert.ToInt32(Console.ReadLine());
        if (bSalary == 0)
        {
            hra = 20 * bSalary / 100;
            da = 10 * bSalary / 100;
            pf = 15 * bSalary / 100;
            gSalary = bSalary + hra + da + pf;
        }
        else
        {
                Console.WriteLine("your Salary is:" + bSalary);

        }
            return bSalary;
    }



}
}