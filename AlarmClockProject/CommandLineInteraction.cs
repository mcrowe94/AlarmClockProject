using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockProject
{
    class CommandLineInteraction
    {
        public static void MainClock(string[] args)
        {
            if (args[0] == "--alarm")
            {
                ClockFunctions.AlarmFunctions(args);
            }
            else if (args[0] == "--stopwatch")
            {
                ClockFunctions.StopwatchFunctions(args);
            }
            else if (args[0] == "--time")
            {
                ClockFunctions.DisplayTime();
            }
            else if (args[0] == "--clockhelp")
            {
                ClockFunctions.HelpMenu();
            }
            else
            {
                ConsoleLogging.PassMessage("Invalid Argument");
            }
        }
    }
}
