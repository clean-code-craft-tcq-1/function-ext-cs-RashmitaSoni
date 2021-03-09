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
            string batteryStatusInEnglish;
            string batteryStatusInGerman;
            if(BatteryConditions.IsBatteryFaultyStatus())
            {
                batteryStatusInEnglish = English.faultyBatteryStatus;
                batteryStatusInGerman = German.faultyBatteryStatus;
            }
            else
            {
                batteryStatusInEnglish = English.normalBatteryStatus;
                batteryStatusInGerman = German.normalBatteryStatus;
            }
            Console.WriteLine("{0}\n{1}", batteryStatusInEnglish, batteryStatusInGerman);
        }
    }
}
