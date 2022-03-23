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

            if (args[0] == "--alarm")
            {
                var userTime = args[1];
                var parseTime = DateTime.Parse(userTime);
                Console.WriteLine(parseTime);

                if(DateTime.Now.Hour == parseTime.Hour && DateTime.Now.Minute == parseTime.Minute)
                {
                    Console.WriteLine("ALARM");
                }
            }
            else if (args[0] == "--stopwatch")
            {                
                var stopWatch = new Stopwatch();
                stopWatch.Start();

                for (int i = 0; i <= 10000; i++)
                {
                    Console.WriteLine(stopWatch.Elapsed);
                }
            }
            else if (args[0] == "--time")
            {                
                var time = DateTime.Now;
                Console.WriteLine(time);
            }
            else if (args[0] == "--help")
            {
                Console.WriteLine("--time for current time" +
                    "\n--alarm plus time to go off for alarm function" +
                    "\n--stopwatch for stopwatch function" +
                    "\n--help for help options");
            }
            else
            {
                Console.WriteLine("Invalid Argument");
            }






        }
    }
}
