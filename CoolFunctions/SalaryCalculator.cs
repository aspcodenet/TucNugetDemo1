using Microsoft.VisualBasic.CompilerServices;

namespace CoolFunctions
{
    public class SalaryCalculator
    {
        public int Calculate(int age, int hoursWorked)
        {
            var salary = hoursWorked * 100;
            if (age >= 50)
                salary += 500;
            return salary;
        }
    }
}