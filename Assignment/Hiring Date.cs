using System;

namespace Assignment
{
    internal class Hiring_Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Hiring_Date(int day, int month, int year)
        {
            if (day >= 1 && day <= 31)
            {
                Day = day;
            }

            if (month >= 1 && month <= 12)
            {
                Month = month;
            }

            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }

    }
}
