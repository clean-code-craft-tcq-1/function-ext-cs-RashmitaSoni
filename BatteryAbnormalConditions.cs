using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryAbnormalConditions
    {
        static bool IsFaulty = false;
        static string factorStatusInEnglish, factorStatusInGerman;
        public static void CheckBreachingPoints(string factorNameInEnglish, string factorNameInGerman, float factorValue, float lowBreachValue,float highBreachValue)
        {
            if (factorValue < lowBreachValue)
            {
                factorStatusInEnglish = English.lowBreachStatus;
                factorStatusInGerman = German.lowBreachStatus;
                IsFaulty = true;
                DisplayAbnormalConditions(factorNameInEnglish, factorNameInGerman, factorStatusInEnglish, factorStatusInGerman);
            }
            if(factorValue > highBreachValue)
            {
                factorStatusInEnglish = English.highBreachStatus;
                factorStatusInGerman = German.highBreachStatus;
                IsFaulty = true;
                DisplayAbnormalConditions(factorNameInEnglish, factorNameInGerman, factorStatusInEnglish, factorStatusInGerman);
            }
        }
        public static void CheckWarningPoints(string factorNameInEnglish, string factorNameInGerman,float factorValue, float lowBreachValue, float lowWarningValue, float highWarningValue, float highBreachValue)
        {
            if (factorValue >= lowBreachValue && factorValue <= lowWarningValue)
            {
                factorStatusInEnglish = English.highBreachStatus;
                factorStatusInGerman = German.highBreachStatus;
                IsFaulty = false;
                DisplayAbnormalConditions(factorNameInEnglish,factorNameInGerman,factorStatusInEnglish,factorStatusInGerman);
            }
            if(factorValue >= highWarningValue && factorValue <= highBreachValue)
            {
                factorStatusInEnglish = English.highBreachStatus;
                factorStatusInGerman = German.highBreachStatus;
                IsFaulty = false;
                DisplayAbnormalConditions(factorNameInEnglish, factorNameInGerman, factorStatusInEnglish, factorStatusInGerman);
            }
        }
        public static void DisplayAbnormalConditions(string factorNameInEnglish, string factorNameInGerman, string factorStatusInEnglish, string factorStatusInGerman)
        {
            Console.WriteLine(factorNameInEnglish + " " + factorStatusInEnglish + "\n" + factorNameInGerman + " " + factorStatusInGerman);
        }
        public static bool IsBatteryFaultyStatus()
        {
            bool isBatteryFaulty = IsFaulty;
            return isBatteryFaulty;
        }
    }
}
