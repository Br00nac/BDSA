using System;

namespace Ass0
{
    public static class LeapYear
    {

        public static void Main(string[] args)
        {

             }

        public static bool IsLeapYear (int year){

                
                return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

            }

        
    }
}
