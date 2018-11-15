using System;
using System.Linq;
using System.Web.Mvc;
using AJF.HomeScreen.WebFront.Models;

namespace AJF.HomeScreen.WebFront.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var schoolScheduleIsa = new SchoolSchedule()
            {
                SchDays = new[]
                {
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Thursday,
                        SchItems = new[]
                        {
                            new SchItem { FromTime = "8.00", ToTime = "8.55", What = "US"},
                        }
                    },
                    new SchDay
                    {
                    DayOfWeek = DayOfWeek.Friday,
                    SchItems = new[]
                    {
                        new SchItem { FromTime = "8.00", ToTime = "8.55", What = "US"},
                    }
                    }
                }
            };

            var schoolScheduleVic = new SchoolSchedule()
            {
                SchDays = new[]
                {
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Monday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "8.00", ToTime = "8.30", What = "M-BÅN"},
                            new SchItem {FromTime = "8.30", ToTime = "9.15", What = "IDR"},
                            new SchItem {FromTime = "9.15", ToTime = "10.00", What = "IDR"},
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Thursday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "8.00", ToTime = "8.30", What = "M-BÅN"},
                            new SchItem {FromTime = "8.30", ToTime = "9.15", What = "MAT/STUD"},
                            new SchItem {FromTime = "9.15", ToTime = "10.00", What = "DAN"},
                            new SchItem {FromTime = "10.20", ToTime = "11.05", What = "DAN"},
                            new SchItem {FromTime = "11.05", ToTime = "11.50", What = "ENG"},
                            new SchItem {FromTime = "11.50", ToTime = "12.20", What = "-Spis-"},
                            new SchItem {FromTime = "12.40", ToTime = "13.25", What = "BIL"},
                            new SchItem {FromTime = "13.25", ToTime = "14.10", What = "KRI"},
                            new SchItem {FromTime = "14.10", ToTime = "14.55", What = "IDR/IDR"},
                        }
                    },
                    new SchDay
                    {
                    DayOfWeek = DayOfWeek.Friday,
                    SchItems = new[]
                    {
                        new SchItem {FromTime = "8.00", ToTime = "8.30", What = "M-BÅN"},
                        new SchItem {FromTime = "8.30", ToTime = "9.15", What = "MAT/STUD"},
                        new SchItem {FromTime = "9.15", ToTime = "10.00", What = "DAN"},
                        new SchItem {FromTime = "10.20", ToTime = "11.05", What = "DAN"},
                        new SchItem {FromTime = "11.05", ToTime = "11.50", What = "ENG"},
                        new SchItem {FromTime = "11.50", ToTime = "12.20", What = "-Spis-"},
                        new SchItem {FromTime = "12.40", ToTime = "13.25", What = "BIL"},
                        new SchItem {FromTime = "13.25", ToTime = "14.10", What = "KRI"},
                        new SchItem {FromTime = "14.10", ToTime = "14.55", What = "IDR/IDR"},
                    }
                    }
                }

            };
            var isabellaDay = schoolScheduleIsa.SchDays.Single(x=>x.DayOfWeek==DateTime.Today.DayOfWeek);
            var victoriaDay = schoolScheduleVic.SchDays.Single(x => x.DayOfWeek == DateTime.Today.DayOfWeek);

            return View(new IndexModel
            {
                SchOwners = new[]
                {
                    new SchOwner(){Name="Isabella", SchDay = isabellaDay},
                    new SchOwner(){Name="Victoria", SchDay = victoriaDay}
                }

            });
        }
    }
}