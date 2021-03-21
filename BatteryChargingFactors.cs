using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingFactors
    {
        public static readonly string ChargingTemperature = "Charging Temperature";
        public static readonly string StateOfCharge = "State of Charge";
        public static readonly string ChargeRate = "Charge Rate";
        public static float minimumChargingTemprature_Celsius = 0;
        public static float maximumChargingTemprature_Celsius = 45;
        public static float minimumChargingTemperatureWarning = (float)(minimumChargingTemprature_Celsius + (maximumChargingTemprature_Celsius * 0.05));
        public static float maximumChargingTemperatureWarning = (float)(maximumChargingTemprature_Celsius - (maximumChargingTemprature_Celsius * 0.05));
        public static float minimumStateOfCharge_Percentage = 20;
        public static float maximumStateOfCharge_Percentage = 80;
        public static float minimumStateOfChargeWarning = (float)(minimumStateOfCharge_Percentage + (maximumStateOfCharge_Percentage * 0.05));
        public static float maximumStateOfChargeWarning = (float)(maximumStateOfCharge_Percentage - (maximumStateOfCharge_Percentage * 0.05));
        public static float minimumChargeRate_CRate = 0.3f;
        public static float maximumChargeRate_CRate = 0.8f;
        public static float minimumChargeRateWarning = (float)(minimumChargeRate_CRate + (maximumChargeRate_CRate * 0.05));
        public static float maximumChargeRateWarning = (float)(maximumChargeRate_CRate - (maximumChargeRate_CRate * 0.05));
    }
}
