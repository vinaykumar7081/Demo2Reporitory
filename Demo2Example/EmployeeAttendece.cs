using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Example
{
   public class EmployeeAttendece
    {
        const int IS_PRESENT =1;
        const int IS_NOT_PRESENT =0;
        public  void DisplayAttendence()
        {
            Random random = new Random();
            int check=random.Next(0, 2);
            switch (check)
            { 
            case IS_PRESENT:
                    Console.WriteLine("Employee is Present");
                    break;

                case IS_NOT_PRESENT:
                    Console.WriteLine("Employee is not Present");
                   
                    break;

            }

        }
    }
}
