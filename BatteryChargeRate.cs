using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargeRate
    {
        static float lowBreachValue = 0.3f;
        static float highBreachValue = 0.8f;
        static float lowWarningValue = (float)(lowBreachValue + (highBreachValue * 0.05));
        static float highWarningValue = (float)(highBreachValue - (highBreachValue * 0.05));
        public static void CheckChargeRate(float chargeRate_CRate)
        {
            BatteryConditions.CheckBatteryConditions(English.chargeRate,German.chargeRate,chargeRate_CRate, lowBreachValue, lowWarningValue, highWarningValue, highBreachValue);
            BatteryConditions.DisplayBatteryFactorsStatus();
        }
    }
}
