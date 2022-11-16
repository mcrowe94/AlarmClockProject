using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockProject
{
    public class ClockFunctions
    {
        public static void DisplayTime()
        {
            var time = DateTime.Now;
            Console.WriteLine(time);
        }

        public static void AlarmFunctions(string[] args)
        {
            var userTime = args[1];
            var parseTime = DateTime.Parse(userTime);
            Console.WriteLine(parseTime);

            if (DateTime.Now.Hour == parseTime.Hour && DateTime.Now.Minute == parseTime.Minute)
            {
                ConsoleLogging.PassMessage("ALARM");
            }
        }

        public static void StopwatchFunctions(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i <= 10000; i++)
            {
                Console.WriteLine(stopWatch.Elapsed);
            }
        }

        public static void HelpMenu()
        {
            ConsoleLogging.PassMessage("--time for current time" +
                    "\n--alarm plus time to go off for alarm function" +
                    "\n--stopwatch for stopwatch function" +
                    "\n--clockhelp for help options"); 
        }
    }
}
