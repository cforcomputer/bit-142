using System;

namespace MyDate_StudentWork
{
    class MyDate // You will need to fill this in! :)
    {
        private int myDateMonth;
        private int myDateDay;

        public MyDate(int month, int day)
        {
            if (month <= 0 || month > 12)
            {
                this.myDateMonth = 1;
            }
            else
            {
                this.myDateMonth = month;
            }
            
            if (day <= this.daysInMonth())
            {
                this.myDateDay = day;
            }                
            else
            {
                this.myDateDay = 1;
            }                
        }
        public MyDate()
        {
            this.myDateDay = 1;
            this.myDateMonth = this.myDateDay;
        }

        public void setDate(int month, int day)
        {
            if (month <= 0 || month > 12)
            {
                this.myDateMonth = 1;
            }
            else
            {
                this.myDateMonth = month;
            }
           
            if (day >= 1 && day <= this.daysInMonth())
            {
                this.myDateDay = day;
            }                
            else
            {
                this.myDateDay = 1;
            }                
        }

        public string toString()
        {
            string returnMonth = this.myDateMonth.ToString();
            int returnDay = this.myDateDay;
            return returnMonth + "/" + returnDay;            
        }

        public bool equals(int bDayMonth, int bDayDay)
        {
            return this.myDateMonth == bDayMonth && this.myDateDay == bDayDay;
        }

        public int daysInMonth()
        {
            // return days in month 
            switch (this.myDateMonth)
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
            
            // else if  if the current day and the birthday date is equal to each other
            // set the current day to 1 to set new month
            if (this.myDateDay == this.daysInMonth())
            {
                this.myDateMonth++;
                this.myDateDay = 1;
            }
            // Year end check
            else if ((this.myDateMonth == 12) && (this.myDateDay == this.daysInMonth()))
            {
                // reset month and day to 1 to start a new year
                this.myDateMonth = 1;
                this.myDateDay = 1;
            }
            // else continue to increment myDateDay to add on to the total number of days
            else
                this.myDateDay++;
        }

        public int getMonth()
        {
            return this.myDateMonth;
        }

        public int getDay()
        {
            return this.myDateDay;
        }
    }
}
