using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryAbnormalConditions
    {
        static bool IsFaulty = false;
        public static void CheckBreachingPoints(float factorValue, float lowBreachValue,float highBreachValue)
        {
            if (factorValue < lowBreachValue || factorValue > highBreachValue)
            {
                IsFaulty = true;
            }
        }
        public static void CheckWarningPoints(float factorValue, float lowBreachValue, float lowWarningValue, float highWarningValue, float highBreachValue)
        {
            if ((factorValue >= lowBreachValue && factorValue <= lowWarningValue) || (factorValue >= highWarningValue && factorValue <= highBreachValue))
            {
                IsFaulty = false;
            }
        }
        public static bool IsBatteryFaultyStatus()
        {
            bool isBatteryFaulty = IsFaulty;
            return isBatteryFaulty;
        }
    }
}
