using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryAbnormalConditions
    {
        public static bool CheckAbnormalConditions(string factorName,float factorValue, float lowBreachValue, float lowWarningValue, float highWarningValue, float highBreachValue)
        {
            if (IsLowBreach(factorName,factorValue, lowBreachValue) || IsHighBreach(factorName,factorValue, highBreachValue))
            {
                return true;
            }
            CheckLowWarning(factorName, factorValue, lowBreachValue, lowWarningValue);
            CheckHighWarning(factorName, factorValue, highBreachValue, highWarningValue);
            return false;

        }
        public static bool IsLowBreach(string factorName, float factorValue, float lowBreachValue)
        {
            if (factorValue < lowBreachValue)
            {
                DisplayAbnormalConditions(factorName, Messages.lowBreachMessageInEnglish, Messages.lowBreachMessageInGerman);
                return true;
            }
            return false;
        }
        public static bool IsHighBreach(string factorName, float factorValue, float highBreachValue)
        {
            if (factorValue > highBreachValue)
            {
                DisplayAbnormalConditions(factorName, Messages.highBreachMessageInEnglish, Messages.highBreachMessageInGerman);
                return true;
            }
            return false;
        }
        public static void CheckLowWarning(string factorName, float factorValue, float lowBreachValue, float lowWarningValue)
        {
            if (factorValue >= lowBreachValue && factorValue <= lowWarningValue) 
            {
                DisplayAbnormalConditions(factorName, Messages.lowWarningMessageInEnglish, Messages.lowWarningMessageInGerman);
            }
        }
        public static void CheckHighWarning(string factorName, float factorValue, float highBreachValue, float highWarningValue)
        {
            if (factorValue >= highWarningValue && factorValue <= highBreachValue)
            {
                DisplayAbnormalConditions(factorName, Messages.highWarningMessageInEnglish, Messages.highWarningMessageInGerman);
            }
        }
        public static void DisplayAbnormalConditions(string factorName, string messageInEnglish, string messageInGerman)
        {
            Console.WriteLine(factorName + " "+ messageInEnglish + "\n" + factorName + " " + messageInGerman);
        }
    }
}
