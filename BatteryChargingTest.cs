using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingTest
    {
        static bool IsBatteryFaulty;
        public static void BatteryChargingTestFactors(float chargingTemperature_Celsius, float stateOfCharge_percentage, float chargeRate_CRate)
        {
            IsBatteryFaulty = 
                BatteryAbnormalConditions.CheckAbnormalConditions(BatteryChargingFactors.ChargingTemperature,chargingTemperature_Celsius,BatteryChargingFactors.minimumChargingTemprature_Celsius,BatteryChargingFactors.minimumChargingTemperatureWarning,BatteryChargingFactors.maximumChargingTemperatureWarning,BatteryChargingFactors.maximumChargingTemprature_Celsius)
                | BatteryAbnormalConditions.CheckAbnormalConditions(BatteryChargingFactors.StateOfCharge,stateOfCharge_percentage,BatteryChargingFactors.minimumStateOfCharge_Percentage,BatteryChargingFactors.minimumStateOfChargeWarning,BatteryChargingFactors.maximumStateOfChargeWarning,BatteryChargingFactors.maximumStateOfCharge_Percentage)
                | BatteryAbnormalConditions.CheckAbnormalConditions(BatteryChargingFactors.ChargeRate,chargeRate_CRate,BatteryChargingFactors.minimumChargeRate_CRate,BatteryChargingFactors.minimumChargeRateWarning,BatteryChargingFactors.maximumChargeRate_CRate,BatteryChargingFactors.maximumChargeRate_CRate);
            DisplayBatteryStatus();
        }
        public static void DisplayBatteryStatus()
        {
            if(IsBatteryFaulty)
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
