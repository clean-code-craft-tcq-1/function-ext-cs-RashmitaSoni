using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryConditions
    {
        static string factorStatusInEnglish, factorStatusInGerman, _factorNameInEnglish, _factorNameInGerman;
        static bool IsFaulty = false;
        public static void CheckBatteryConditions(string factorNameInEnglish, string factorNameInGerman, float factorValue, float lowBreachValue, float lowWarningValue, float highWarningValue, float highBreachValue)
        {
            _factorNameInEnglish = factorNameInEnglish;
            _factorNameInGerman = factorNameInGerman;
            if (factorValue < lowBreachValue)
            {
                factorStatusInEnglish = English.lowBreachStatus;
                factorStatusInGerman = German.lowBreachStatus;
                IsFaulty = true;
            }
            else if (factorValue >= lowBreachValue && factorValue <= lowWarningValue)
            {
                factorStatusInEnglish = English.lowWarningStatus;
                factorStatusInGerman = German.lowWarningStatus;
                IsFaulty = false;
            }
            else if (factorValue > lowWarningValue && factorValue < highWarningValue)
            {
                factorStatusInEnglish = English.normalStatus;
                factorStatusInGerman = German.normalStatus;
                IsFaulty = false;
            }
            else if (factorValue >= highWarningValue && factorValue <= highBreachValue)
            {
                factorStatusInEnglish = English.highWarningStatus;
                factorStatusInGerman = German.highWarningStatus;
                IsFaulty = false;
            }
            else if (factorValue > highBreachValue)
            {
                factorStatusInEnglish = English.highBreachStatus;
                factorStatusInGerman = German.highBreachStatus;
                IsFaulty = true;
            }
        }
        public static void DisplayBatteryFactorsStatus()
        {
            Console.WriteLine(_factorNameInEnglish + " "+ factorStatusInEnglish + "\n" + _factorNameInGerman + " " + factorStatusInGerman);
        }
        public static bool IsBatteryFaultyStatus()
        {
            bool isBatteryFaulty = IsFaulty;
            return isBatteryFaulty;
        }
    }
}
