using System;

namespace AJF.HomeScreen.WebFront.Models
{
    public class SchDay
    {
        public DayOfWeek DayOfWeek { get; set; }
        public SchItem[] SchItems { get; set; }
    }
}