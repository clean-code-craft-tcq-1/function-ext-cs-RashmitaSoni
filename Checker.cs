using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class Checker
    {
        public static int Main()
        {
            BatteryChargingTest.BatteryChargingTestFactors(25, 70, 0.7f);
            BatteryChargingTest.BatteryChargingTestFactors(50, 85, 0.0f);
            return 0;
        }
    }
}
