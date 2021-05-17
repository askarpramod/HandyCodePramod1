using System;
using System.Collections.Generic;
using System.Text;

namespace StringOperations
{
  public class DateTimeClass
    {
      public void ShowDiffFormat()

        {
            DateTime d = DateTime.Parse("05:00 PM");
            Console.WriteLine("Date time Value is : " +d);
            Console.WriteLine("Converted 24 Hrs time is : " + d.ToString("HH:mm"));

            Console.ReadKey();
            
        }

        public void GetAngleBetweenHourAndMinuteHand1()
        {
           // https://dotnettutorials.net/lesson/how-to-find-the-angle-between-hour-and-minutehands-of-a-clock-at-any-given-time/

            Console.Write("Enter the hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());

            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegrees = minutes * 6;
            double diff = Math.Abs(hourInDegrees - minuteInDegrees);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {diff} degrees");
           // Console.ReadKey();
        }


            public void GetAngleBetweenHourAndMinuteHand2()
            {
            Console.Write("Enter the hours : ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minutes : ");
            int minute = int.Parse(Console.ReadLine());
            //∆θ=|5(6H-11/10M) |0  
            //hour =>H   
            //minute=>M  
            var angle = Math.Abs(5 * ((6 * hour) - (1.1 * minute)));
            Console.WriteLine($"Angle between {hour} hour and {minute} minute is {angle} degrees");
        }
     
    }
}
