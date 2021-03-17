using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BatteryCharging
{
    public interface IReporter
    {
        void DisplayBatteryStatus(bool IsBatteryFaulty, List<Tuple<string, string>> batteryReports);
    }
    public class BatteryReporter : IReporter
    {
        public void DisplayBatteryStatus(bool IsBatteryFaulty, List<Tuple<string, string>> batteryReports)
        {
            foreach (var item in batteryReports)
            {
                Console.WriteLine("{0}\n{1}", item.Item1, item.Item2.ToString());
            }
            if (IsBatteryFaulty)
            {
                Console.WriteLine("Battery is faulty\nBatterie ist defekt");
            }
            else
            {
                Console.WriteLine("Battery is OK\nBatterie ist in Ordnung");
            }
        }
    }
}
