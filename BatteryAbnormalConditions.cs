using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryAbnormalConditions
    {
        static bool IsFaulty = false;
        static string lowBreachMessageInEnglish = "Breaching point is low";
        static string lowBreachMessageInGerman = "Der Bruchpunkt ist niedrig";
        static string highBreachMessageInEnglish = "Breaching point is high";
        static string highBreachMessageInGerman = "Der Bruchpunkt ist hoch";
        static string lowWarningMessageInEnglish = "Warning: Approaching discharge";
        static string lowWarningMessageInGerman = "Warnung: Annäherung an die Entladung";
        static string highWarningMessageInEnglish = "Warning: Approaching charge-peak";
        static string highWarningMessageInGerman = "Warnung: Annäherung an die Ladungsspitze";
        public static void CheckAbnormalConditions(string factorName,float factorValue, float lowBreachValue, float lowWarningValue, float highWarningValue, float highBreachValue)
        {
            if (factorValue < lowBreachValue)
            {
                IsFaulty = true;
                DisplayAbnormalConditions(factorName, lowBreachMessageInEnglish, lowBreachMessageInGerman);
            }
            if(factorValue > highBreachValue)
            {
                IsFaulty = true;
                DisplayAbnormalConditions(factorName, highBreachMessageInEnglish, highBreachMessageInGerman);
            }
            else
            {
                CheckLowWarning(factorName, factorValue, lowBreachValue, lowWarningValue);
                CheckHighWarning(factorName, factorValue, highBreachValue, highWarningValue);
            }
        }
        public static void CheckLowWarning(string factorName, float factorValue, float lowBreachValue, float lowWarningValue)
        {
            if (factorValue >= lowBreachValue && factorValue <= lowWarningValue) 
            {
                IsFaulty = false;
                DisplayAbnormalConditions(factorName, lowWarningMessageInEnglish, lowWarningMessageInGerman);
            }
        }
        public static void CheckHighWarning(string factorName, float factorValue, float highBreachValue, float highWarningValue)
        {
            if (factorValue >= highWarningValue && factorValue <= highBreachValue)
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
