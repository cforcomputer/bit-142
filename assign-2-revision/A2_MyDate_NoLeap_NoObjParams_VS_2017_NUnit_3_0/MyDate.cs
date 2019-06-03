using System;

namespace MyDate_StudentWork
{
    class MyDate // You will need to fill this in! :)
    {
        // Remove the 'myDate' prefix from the instance variables.  It gets repetitive and doesn't add a lot of information 
        private int Month;
        private int Day;

        public MyDate(int month, int day)
        {

            // The constructor which takes the two integer arguments (public MyDate(int month, int day) ) should call setDate. 
            // This will reduce the amount of code that you duplicate.  

            setDate(month, day);
            //if (month <= 0 || month > 12)
            //{
            //    this.Month = 1;
            //}
            //else
            //{
            //    this.Month = month;
            //}

            //if (day <= this.daysInMonth())
            //{
            //    this.Day = day;
            //}                
            //else
            //{
            //    this.Day = 1;
            //}                
        }
        public MyDate()
        {
            this.Day = 1;
            this.Month = this.Day;
        }

        public void setDate(int month, int day)
        {
            if (month <= 0 || month > 12)
            {
                this.Month = 1;
            }
            else
            {
                this.Month = month;
            }

            if (day >= 1 && day <= this.daysInMonth())
            {
                this.Day = day;
            }
            else
            {
                this.Day = 1;
            }
        }

        public string toString()
        {
            string returnMonth = this.Month.ToString();
            int returnDay = this.Day;
            return returnMonth + "/" + returnDay;
        }

        public bool equals(int bDayMonth, int bDayDay)
        {
            return this.Month == bDayMonth && this.Day == bDayDay;
        }

        public int daysInMonth()
        {
            // return days in month 
            switch (this.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    return 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 0;
            }
        }

        // Check to see if the current month is greater than the birthday month
        // if it is: then change 1 once it reaches 12, so it does not go above the months in a year
        // and create an infinite loop.
        public void nextDay()
        {
            // CORRECTION: If the date is December 31st then you should change the day to 1 (which you're doing) AND change the month to 1 
            // Reverse the orders of the checks
            // else if  if the current day and the birthday date is equal to each other
            // set the current day to 1 to set new month
            // Year end check
            if ((this.Month == 12) && (this.Day == this.daysInMonth()))
            {
                // reset month and day to 1 to start a new year
                this.Month = 1;
                this.Day = 1;

            }
            else if (this.Day == this.daysInMonth())
            {
                this.Month++;
                this.Day = 1;
            }
            // else continue to increment Day to add on to the total number of days
            else
                this.Day++;
            Console.WriteLine(this.Day);
        }

        public int getMonth()
        {
            return this.Month;
        }

        public int getDay()
        {
            return this.Day;
        }
    }
}
