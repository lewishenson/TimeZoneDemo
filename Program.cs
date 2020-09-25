using System;

namespace TimeZoneDemo
{
    class Program
    {
        static void Main(string[] _)
        {
            Console.WriteLine("Time Zone demo");

            var systemTimeZones = TimeZoneInfo.GetSystemTimeZones();
            Console.WriteLine($"{systemTimeZones.Count} time zones present");

            Console.WriteLine();

            // Valid for Windows
            GetTimeZone("GMT Standard Time");

            Console.WriteLine();

            // Valid for Linux
            GetTimeZone("Europe/London");
        }

        static void GetTimeZone(string timeZoneId)
        {
            try
            {
                Console.WriteLine($"Getting time zone {timeZoneId}...");

                var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                Console.WriteLine($"{timeZoneInfo.DisplayName} ({timeZoneInfo.StandardName})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to get time zone {timeZoneId}!");
                Console.WriteLine(ex);
            }
        }
    }
}
