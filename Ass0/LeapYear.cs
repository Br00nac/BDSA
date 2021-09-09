using System;

namespace Ass0
{
    public static class LeapYear
    {

        public static void Main(string[] args)
        {
            try{
            var input = Console.ReadLine();
            if(IsLeapYear(Int32.Parse(input)))Console.Write("yay");
                else Console.Write("nay"); 
            } catch(Exception e){Console.Write("Input is not an integer");};

         }

        public static bool IsLeapYear (int year){

                if(year < 1582)throw new Exception("No years earlier than 1582 allowed!");
                return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

            }

        
    }
}
