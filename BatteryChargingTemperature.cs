using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingTemperature
    {
        static float lowBreachValue = 0;
        static float highBreachValue = 45;
        static float lowWarningValue = (float)(lowBreachValue + (highBreachValue * 0.05));
        static float highWarningValue = (float)(highBreachValue - (highBreachValue * 0.05));
        public static void CheckChargingTemperature(float chargingTemperature_Celsius)
        {
            BatteryAbnormalConditions.CheckBreachingPoints(English.chargingTemperature,German.chargingTemperature,chargingTemperature_Celsius, lowBreachValue, highBreachValue);
            BatteryAbnormalConditions.CheckWarningPoints(English.chargingTemperature, German.chargingTemperature,chargingTemperature_Celsius, lowBreachValue, lowWarningValue, highWarningValue, highBreachValue);
        }
    }
}
