using System;

namespace Ass0
{
    public static class LeapYear
    {

        public static void Main(string[] args)
        {
            var input = Console.Read();
            if(IsLeapYear(input))Console.Write("yay");
                else Console.Write("nay"); 

         }

        public static bool IsLeapYear (int year){

                if(year < 1582)return false;
                return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

            }

        
    }
}
