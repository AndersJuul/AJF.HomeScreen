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
            var schoolScheduleIsa = new SchoolSchedule
            {
                SchDays = new[]
                {
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Monday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "8.00", ToTime = "8.45", What = "DA"},
                            new SchItem {FromTime = "8.45", ToTime = "9.30", What = "MAT"},
                            new SchItem {FromTime = "9.30", ToTime = "09.55", What = "PAUSE"},
                            new SchItem {FromTime = "09.55", ToTime = "10.40", What = "IDR"},
                            new SchItem {FromTime = "10.40", ToTime = "11.25", What = "IDR"},
                            new SchItem {FromTime = "11.25", ToTime = "12.00", What = "PAUSE"},
                            new SchItem {FromTime = "12.00", ToTime = "12.45", What = "HIS"},
                            new SchItem {FromTime = "12.45", ToTime = "13.30", What = "TYSK"},
                            new SchItem {FromTime = "13.30", ToTime = "13.45", What = "PAUSE"},
                            new SchItem {FromTime = "13.45", ToTime = "14.30", What = "STUD"},
                            new SchItem {FromTime = "14.30", ToTime = "15.15", What = "STUD"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Tuesday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "8.00", ToTime = "8.55", What = "US"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Wednesday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "8.00", ToTime = "8.55", What = "US"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Thursday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "8.00", ToTime = "8.55", What = "US"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Friday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "8.00", ToTime = "8.55", What = "US"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Saturday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "", ToTime = "", What = "Weekend!"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Sunday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "", ToTime = "", What = "Weekend!"}
                        }
                    }
                }
            };

            var schoolScheduleVic = new SchoolSchedule
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
                            new SchItem {FromTime = "10.20", ToTime = "11.05", What = "HDS"},
                            new SchItem {FromTime = "11.05", ToTime = "11.50", What = "HDS"},
                            new SchItem {FromTime = "11.50", ToTime = "12.20", What = "-Spis-"},
                            new SchItem {FromTime = "12.40", ToTime = "13.25", What = "ENG"},
                            new SchItem {FromTime = "13.25", ToTime = "14.10", What = "ENG"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Tuesday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "8.00", ToTime = "8.30", What = "M-BÅN"},
                            new SchItem {FromTime = "8.30", ToTime = "9.15", What = "MAT"},
                            new SchItem {FromTime = "9.15", ToTime = "10.00", What = "MAT"},
                            new SchItem {FromTime = "10.20", ToTime = "11.05", What = "HIS"},
                            new SchItem {FromTime = "11.05", ToTime = "11.50", What = "HIS"},
                            new SchItem {FromTime = "11.50", ToTime = "12.20", What = "-Spis-"},
                            new SchItem {FromTime = "12.40", ToTime = "13.25", What = "DAN"},
                            new SchItem {FromTime = "13.25", ToTime = "14.10", What = "DAN/STUD"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Wednesday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "8.00", ToTime = "8.55", What = "US"}
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
                            new SchItem {FromTime = "14.10", ToTime = "14.55", What = "IDR/IDR"}
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
                            new SchItem {FromTime = "14.10", ToTime = "14.55", What = "IDR/IDR"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Saturday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "", ToTime = "", What = "Weekend!"}
                        }
                    },
                    new SchDay
                    {
                        DayOfWeek = DayOfWeek.Sunday,
                        SchItems = new[]
                        {
                            new SchItem {FromTime = "", ToTime = "", What = "Weekend!"}
                        }
                    }
                }
            };

            var desiredDays = new[] {DateTime.Today.DayOfWeek, DateTime.Today.AddDays(1).DayOfWeek};

            var isabellaDays = desiredDays.Select(yy => schoolScheduleIsa.SchDays.Single(x => x.DayOfWeek == yy))
                .ToArray();
            var victoriaDays = desiredDays.Select(yy => schoolScheduleVic.SchDays.Single(x => x.DayOfWeek == yy))
                .ToArray();

            return View(new IndexModel
            {
                SchOwners = new[]
                {
                    new SchOwner {Name = "Isabella", SchDays = isabellaDays},
                    new SchOwner {Name = "Victoria", SchDays = victoriaDays}
                }
            });
        }
    }
}