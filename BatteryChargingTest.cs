using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingTest
    {
        public static void BatteryChargingTestFactors(float chargingTemperature_Celsius, float stateOfCharge_percentage, float chargeRate_CRate)
        {
            BatteryChargingTemperature.CheckChargingTemperature(chargingTemperature_Celsius);
            BatteryStateOfCharge.CheckStateOfCharge(stateOfCharge_percentage);
            BatteryChargeRate.CheckChargeRate(chargeRate_CRate);
            DisplayBatteryStatus();
        }
        public static void DisplayBatteryStatus()
        {
            if(BatteryAbnormalConditions.IsBatteryFaultyStatus())
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
