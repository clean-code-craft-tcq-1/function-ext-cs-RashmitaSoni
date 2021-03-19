using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class Checker
    {
        public static int Main()
        {
            IReporter _reporterRef = new BatteryMeasuresReporter();
            BatteryChargingTest _batteryTester = new BatteryChargingTest(_reporterRef);
            BatteryChargingTest.BatteryChargingTestFactors(25, 70, 0.7f);
            BatteryChargingTest.BatteryChargingTestFactors(50, 23, 0.0f);
            return 0;
        }
    }
}
