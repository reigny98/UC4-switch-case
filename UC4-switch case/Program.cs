using System;

namespace UC4_switch_case
{
    internal class Program
    {
        public static void Main(String[] args)
        {

            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWages = 0;
            Random random = new Random();
            int hours = random.Next(0, 3);
            switch (hours)
            {

                case 1:
                    empHrs = 8;
                    break;

                case 2:
                    empHrs = 4;
                    break;

                default :
                    empHrs = 0;
                    break;
         
            }
            empWages = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wages :" + empWages);

        }

    }
}
