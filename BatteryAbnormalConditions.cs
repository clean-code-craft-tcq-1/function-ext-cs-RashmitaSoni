using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryAbnormalConditions
    {
        static bool IsFaulty = false;
        static string breachMessageInEnglish = "Breaching point reached";
        static string breachMessageInGerman = "Bruchstelle erreicht";
        static string lowWarningMessageInEnglish = "Warning: Approaching discharge";
        static string lowWarningMessageInGerman = "Warnung: Annäherung an die Entladung";
        static string highWarningMessageInEnglish = "Warning: Approaching charge-peak";
        static string highWarningMessageInGerman = "Warnung: Annäherung an die Ladungsspitze";
        public static void CheckAbnormalConditions(string factorName,float factorValue, float lowBreachValue, float lowWarningValue, float highWarningValue, float highBreachValue)
        {
            if (factorValue < lowBreachValue || factorValue > highBreachValue)
            {
                IsFaulty = true;
                DisplayAbnormalConditions(factorName, breachMessageInEnglish, breachMessageInGerman);
            }
            if (factorValue >= lowBreachValue && factorValue <= lowWarningValue)
            {
                IsFaulty = false;
                DisplayAbnormalConditions(factorName, lowWarningMessageInEnglish, lowWarningMessageInGerman);
            }
            if(factorValue >= highWarningValue && factorValue <= highBreachValue)
            {
                IsFaulty = false;
                DisplayAbnormalConditions(factorName, highWarningMessageInEnglish, highWarningMessageInGerman);
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
