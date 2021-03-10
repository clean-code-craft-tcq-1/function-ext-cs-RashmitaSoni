using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryAbnormalConditions
    {
        static readonly string LowBreach = "Breaching Point is Low";
        static readonly string HighBreach = "Breaching Point is High";
        static bool FaultyBattery = false;
        public static void CheckBreachingPoint(string factorName, float factorValue, float minimumFactorLimit, float maximumFactorLimit)
        { 
            if (factorValue < minimumFactorLimit)
            {
                DisplayAbnormalConditions(factorName, minimumFactorLimit, maximumFactorLimit,LowBreach);
                FaultyBattery = true;
            }
            if (factorValue > maximumFactorLimit)
            {
                DisplayAbnormalConditions(factorName, minimumFactorLimit, maximumFactorLimit,HighBreach);
                FaultyBattery = true;
            }
        }
        public static void DisplayAbnormalConditions(string factorName, float minimumFactorLimit, float maximumFactorLimit, string breachPoint)
        {
            Console.WriteLine("{0} is out of range!\nRange is ({1},{2})\n{3}",factorName,minimumFactorLimit,maximumFactorLimit,breachPoint);
        }
        public static bool GetBatteryFaultyStatus()
        {
            bool faultyBattery = FaultyBattery;
            return faultyBattery;
        }
    }
}
