using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding2.Models
{
    public class Time
    {
        public static DateTime weddingDate = new DateTime(2022, 08, 13);

        public Time()
        {

        }
        public static string GetDate(){

            DateTime now = DateTime.Now;
            TimeSpan timeTo = weddingDate - now;
            return timeTo.Days.ToString();
        }

    }
}
