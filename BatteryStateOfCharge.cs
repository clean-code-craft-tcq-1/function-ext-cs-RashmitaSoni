using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryStateOfCharge
    {
        static float lowBreachValue = 20;
        static float highBreachValue = 80;
        static float lowWarningValue = (float)(lowBreachValue + (highBreachValue * 0.05));
        static float highWarningValue = (float)(highBreachValue - (highBreachValue * 0.05));
        public static void CheckStateOfCharge(float stateOfCharge_percentage)
        {
            BatteryAbnormalConditions.CheckBreachingPoints(English.stateOfCharge, German.stateOfCharge,stateOfCharge_percentage, lowBreachValue, highBreachValue);
            BatteryAbnormalConditions.CheckWarningPoints(English.stateOfCharge, German.stateOfCharge,stateOfCharge_percentage, lowBreachValue, lowWarningValue, highWarningValue, highBreachValue);
        }
    }
}
