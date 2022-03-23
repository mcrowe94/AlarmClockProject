using System;
using System.Diagnostics;

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
            
            //var stopWatch = new Stopwatch();
            

            if (args[0] == "--alarm")
            {
                var userTime = args[1];
                var parseTime = DateTime.Parse(userTime);
                Console.WriteLine(parseTime);

                if(DateTime.Now.Hour == parseTime.Hour && DateTime.Now.Minute == parseTime.Minute)
                {
                    //play Youtube
                }
            }






        }
    }
}
