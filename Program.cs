using System;

namespace UC4UsingCaseStatement
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {


            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);
            switch (empCheck)

            {
                case IS_PART_TIME:
                    EmpHrs = 4;
                    break;

                case IS_FULL_TIME:
                    EmpHrs = 8;
                    break;
                default:


                    EmpHrs = 0;
                    break;
            }

            EmpWage = EmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage:" + EmpWage);
        }
    }
}