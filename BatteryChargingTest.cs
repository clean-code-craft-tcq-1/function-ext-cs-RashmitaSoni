using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingTest
    {
       public static void BatteryChargingTestFactors(float chargingTemperature_Celsius, float stateOfCharge_percentage, float chargeRate_CRate)
        {
            BatteryChargingFactors.CheckChargingTemperature(chargingTemperature_Celsius);
            BatteryChargingFactors.CheckStateOfCharge(stateOfCharge_percentage);
            BatteryChargingFactors.CheckChargeRate(chargeRate_CRate);
            DisplayBatteryStatus();
        }
       public static void DisplayBatteryStatus()
        {
            string BatteryStatus = (BatteryAbnormalConditions.GetBatteryFaultyStatus() == true) ? "Battery is faulty" : "Battery is OK";
            Console.WriteLine(BatteryStatus);
        }
    }
}
