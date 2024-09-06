using System;

namespace CliqMate.Shared.Helpers
{
    public static class DateTimeHelper
    {
        // Formats a DateTime to a user-friendly string
        public static string ToFriendlyDateString(DateTime dateTime)
        {
            return dateTime.ToString("MMMM dd, yyyy");
        }

        // Formats a DateTime to a standard date-time format (e.g., for logging or display purposes)
        public static string ToStandardDateTimeString(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // Calculates the difference in years between two dates (for example, for calculating a user's age)
        public static int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--; // Adjust for leap year
            return age;
        }

        // Returns the number of days between two dates
        public static int DaysBetween(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Days;
        }

        // Converts a UTC DateTime to local time based on a time zone
        public static DateTime ToLocalTime(DateTime utcDateTime, string timeZoneId)
        {
            try
            {
                TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, timeZone);
            }
            catch (TimeZoneNotFoundException)
            {
                throw new Exception("Time zone not found.");
            }
            catch (InvalidTimeZoneException)
            {
                throw new Exception("Invalid time zone.");
            }
        }

        // Converts a local DateTime to UTC based on a time zone
        public static DateTime ToUtcTime(DateTime localDateTime, string timeZoneId)
        {
            try
            {
                TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                return TimeZoneInfo.ConvertTimeToUtc(localDateTime, timeZone);
            }
            catch (TimeZoneNotFoundException)
            {
                throw new Exception("Time zone not found.");
            }
            catch (InvalidTimeZoneException)
            {
                throw new Exception("Invalid time zone.");
            }
        }
    }
}
