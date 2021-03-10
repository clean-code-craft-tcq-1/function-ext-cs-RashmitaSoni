using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryAbnormalConditions
    {
        static bool IsFaulty = false;
        static string breachMessageInEnglish = "Breaching point reached";
        static string breachMessageInGerman = "Bruchstelle erreicht";
        static string warningMessageInEnglish = "Warning: Approaching breaching point";
        static string warningMessageInGerman = "Warnung: Annäherung an die Bruchstelle";
        public static void CheckAbnormalConditions(string factorName,float factorValue, float lowBreachValue, float lowWarningValue, float highWarningValue, float highBreachValue)
        {
            if (factorValue < lowBreachValue || factorValue > highBreachValue)
            {
                IsFaulty = true;
                DisplayAbnormalConditions(factorName, breachMessageInEnglish, breachMessageInGerman);
            }
            if (factorValue >= lowBreachValue && factorValue <= lowWarningValue || factorValue >= highWarningValue && factorValue <= highBreachValue)
            {
                IsFaulty = false;
                DisplayAbnormalConditions(factorName, warningMessageInEnglish, warningMessageInGerman);
            }
        }
        public static void DisplayAbnormalConditions(string factorName, string messageInEnglish, string messageInGerman)
        {
            Console.WriteLine(factorName + " "+ messageInEnglish + "\n" + factorName + " " + messageInGerman);
        }
        public static bool IsBatteryFaultyStatus()
        {
            bool isBatteryFaulty = IsFaulty;
            return isBatteryFaulty;
        }
    }
}
