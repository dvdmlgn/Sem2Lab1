using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    // a miscellaneous class to hold ultility functions
    public static class Miscella
    {
        public static DateTime GetRandomDate()
        {
            Random r = new Random();

            //DateTime theRandomDate = new DateTime(r.Next)


            //get today
            DateTime today = DateTime.Now;


            //get date in past
            DateTime dayInPast = today.AddYears(-20);


            //get diff
            TimeSpan diff = today - dayInPast;

            //convert to minutes
            int numberOfMinutes = diff.Minutes;


            //get random number of mi
            int randomMins = r.Next(0, numberOfMinutes);


            TimeSpan newSpan = new TimeSpan(0, randomMins, 0);

            DateTime newDate = dayInPast + newSpan;

            return newDate;
        }
    }
}
