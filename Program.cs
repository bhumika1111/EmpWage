using System;

namespace UC3AddPartTimeEmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HRS = 20;

            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {

                EmpHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                EmpHrs = 8;
            }
            else
            {
                EmpHrs = 0;
            }

            EmpWage = EmpHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Emp Wage:" + EmpWage);
        }
    }
}
