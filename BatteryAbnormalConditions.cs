using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryAbnormalConditions
    {
        public static List<Tuple<string,string>> factorsConditions = new List<Tuple<string, string>>();
        public static bool CheckAbnormalConditions(string factorName, float factorValue, float lowBreachValue, float lowWarningValue, float highWarningValue, float highBreachValue)
        {
            if (IsLowBreach(factorName, factorValue, lowBreachValue) || IsHighBreach(factorName, factorValue, highBreachValue))
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
                factorsConditions.Add(new Tuple<string, string>(factorName + " " + EnglishLanguage.lowBreachMessage, factorName + " " + GermanLanguage.lowBreachMessage));
                return true;
            }
            return false;
        }
        public static bool IsHighBreach(string factorName, float factorValue, float highBreachValue)
        {
            if (factorValue > highBreachValue)
            {
                factorsConditions.Add(new Tuple<string, string>(factorName + " " + EnglishLanguage.highBreachMessage, factorName + " " + GermanLanguage.highBreachMessage));
                return true;
            }
            return false;
        }
        public static void CheckLowWarning(string factorName, float factorValue, float lowBreachValue, float lowWarningValue)
        {
            if (factorValue >= lowBreachValue && factorValue <= lowWarningValue)
            {
                factorsConditions.Add(new Tuple<string, string>(factorName + " " + EnglishLanguage.lowWarningMessage, factorName + " " + GermanLanguage.lowWarningMessage));
            }
        }
        public static void CheckHighWarning(string factorName, float factorValue, float highBreachValue, float highWarningValue)
        {
            if (factorValue >= highWarningValue && factorValue <= highBreachValue)
            {
                factorsConditions.Add(new Tuple<string, string>(factorName + " " + EnglishLanguage.highWarningMessage, factorName + " " + GermanLanguage.highWarningMessage));
            }
        }
    }
}
