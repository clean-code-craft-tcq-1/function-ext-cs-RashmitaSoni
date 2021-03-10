using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingFactors
    {
        static float minimumChargingTemprature_Celsius = 0;
        static float maximumChargingTemprature_Celsius = 45;
        static float minimumChargingTemperatureWarning = (float)(minimumChargingTemprature_Celsius + (maximumChargingTemprature_Celsius * 0.05));
        static float maximumChargingTemperatureWarning = (float)(maximumChargingTemprature_Celsius - (maximumChargingTemprature_Celsius * 0.05));
        static float minimumStateOfCharge_Percentage = 20;
        static float maximumStateOfCharge_Percentage = 80;
        static float minimumStateOfChargeWarning = (float)(minimumStateOfCharge_Percentage + (maximumStateOfCharge_Percentage * 0.05));
        static float maximumStateOfChargeWarning = (float)(maximumStateOfCharge_Percentage - (maximumStateOfCharge_Percentage * 0.05));
        static float minimumChargeRate_CRate = 0.3f;
        static float maximumChargeRate_CRate = 0.8f;
        static float minimumChargeRateWarning = (float)(minimumChargeRate_CRate + (maximumChargeRate_CRate * 0.05));
        static float maximumChargeRateWarning = (float)(maximumChargeRate_CRate - (maximumChargeRate_CRate * 0.05));
        public static void CheckChargingTemperature(float chargingTemperature_Celsius)
        {
            BatteryAbnormalConditions.CheckAbnormalConditions("Charging Temperature",chargingTemperature_Celsius, minimumChargingTemprature_Celsius, minimumChargingTemperatureWarning, maximumChargingTemperatureWarning,maximumChargingTemprature_Celsius);
        }
        public static void CheckStateOfCharge(float stateOfCharge_percentage)
        {
            BatteryAbnormalConditions.CheckAbnormalConditions("State Of Charge",stateOfCharge_percentage, minimumStateOfCharge_Percentage, minimumStateOfChargeWarning, maximumStateOfChargeWarning, maximumStateOfCharge_Percentage);
        }
        public static void CheckChargeRate(float chargeRate_CRate)
        {
            BatteryAbnormalConditions.CheckAbnormalConditions("Charge Rate",chargeRate_CRate, minimumChargeRate_CRate, minimumChargeRateWarning, maximumChargeRateWarning, maximumChargeRate_CRate);
        }
    }
}
