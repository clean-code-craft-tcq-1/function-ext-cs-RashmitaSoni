using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BatteryCharging
{
    public interface IReporter
    {
        void DisplayBatteryStatus(List<Tuple<string, string>> batteryReports);
    }
    public class BatteryMeasuresReporter : IReporter
    {
        public void DisplayBatteryStatus(List<Tuple<string, string>> batteryReports)
        {
            foreach (var item in batteryReports)
            {
                Console.WriteLine("{0}\n{1}", item.Item1, item.Item2.ToString());
            }
        }
    }
}
