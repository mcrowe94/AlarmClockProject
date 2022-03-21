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
            var current = DateTime.Now;

            Console.WriteLine(parseTime);
            Console.WriteLine(current);

                      
            
        }
    }
}
