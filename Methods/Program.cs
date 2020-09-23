using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //  The user will enter 
                //      Y, M, or D to get the Year, Month or Day of the current date
                //      h, m, or s to get the hour, minute, or second of the current time
                string part = Utils.GetInput("What part of the date are you interested in? (M or D or Y for month day or year): ");

                //  this method will take the part of the date requested and from the current date return the units for that date part or time part
                int timeUnit = GetDatePart(part);
                if (timeUnit == -1)
                    break;
                Console.WriteLine($"The time part represented by {part} is {timeUnit}");
            }
        }
        static int GetDatePart(string part)
        {
           int numberDate = 0;
            if(part == "Y")
            {
                numberDate = DateTime.Today.Year;
            }
            if(part == "M")
            {
                numberDate = DateTime.Today.Month;
            }
            if (part == "D")
            {
               numberDate = DateTime.Today.Day;
            }
            return numberDate;
        }
    }
}
