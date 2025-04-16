using System;
using System.Collections.Generic;
using GymActivities.Models;
namespace GymActivities
{
    class Program
    {
        static void Main()
        {
            try
            {
                var activities = new List<Activity>
                {
                    new Running("03 Nov 2022", 30, 4.8),
                    new Cycling("03 Nov 2022", 30, 9.7),
                    new Swimming("03 Nov 2022", 30, 20)
                };
                foreach (var activity in activities)
                {
                    Console.WriteLine(activity.GetSummary());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}