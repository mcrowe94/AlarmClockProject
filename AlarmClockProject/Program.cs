using System;

namespace AlarmClockProject
{
    // user will pass in a time in the console
    // parse the time
    // start timer
    // alert user after time up
    class Program
    {
        static void Main(string[] args)
        {
            var userTime = (args[0]);
            var parseTime = DateTime.Parse(userTime);

            if(DateTime.Now.Hour == parseTime.Hour && DateTime.Now.Minute == parseTime.Minute)
            {
                //play YouTube Video
            }

            

                      
            
        }
    }
}
