using System;

namespace SampleMobileAutomationTests.Methods
{
    public class DateTimeMethods
    {
        public string GenerateDate(int count, string timeUnit)
        {
            var currentDate = DateTime.Now;

            return timeUnit switch
            {
                "days" => currentDate.AddDays(count).ToString("MMMM/d/yyyy"),
                "months" => currentDate.AddMonths(count).ToString("MMMM/d/yyyy"),
                "year" => currentDate.AddYears(count).ToString("MMMM/d/yyyy"),
                _ => currentDate.ToString("MMMM/d/yyyy")
            };
        }
    }
}