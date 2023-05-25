using System;

namespace AnalogClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hours (0-11):");
            string input = Console.ReadLine();
            int hours = int.Parse(input);

            if (hours == 12)
            {
                Console.WriteLine("Instead of 12 you can write 0. Please rerun the program.");
                Environment.Exit(0);
            }

            Console.WriteLine("Enter the minutes (0-59):");
            input = Console.ReadLine();
            double minutes = int.Parse(input);

            // Hour hand makes a full turn in 12 hours. It means that each hour, it moves by 30 degrees. 360 / 12 = 30
            hours = hours * 30;
            // Each minute, it moves by half a degree.
            double myminutes = minutes * 0.5;


            // Adding hours and minutes to get hour angle
            double hour_Angle = hours + myminutes;
         

            // Every minute it moves by 6 degrees. 360 / 60 (1 minute) = 6
            double minute_Angle = minutes * 6;
        

            double lesser_angle = 0;

            // if condition to know the inside angle and not the outside angle
            if (minute_Angle > hour_Angle)
            {
                lesser_angle = minute_Angle - hour_Angle;

            }
            else
            {
                lesser_angle = hour_Angle - minute_Angle;
            }


            // Get the absolute value and not negatives
            lesser_angle = Math.Abs(lesser_angle);



            Console.WriteLine("The lesser angle between the hour and minute hands is: " + lesser_angle + " degrees");
        }
    }
}
