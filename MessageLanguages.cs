using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class GermanLanguage
    {
        public static string lowBreachMessage = "Der Bruchpunkt ist niedrig";
        public static string highBreachMessage = "Der Bruchpunkt ist hoch";
        public static string lowWarningMessage = "Warnung: Annäherung an die Entladung";
        public static string highWarningMessage = "Warnung: Annäherung an die Ladungsspitze";
    }
    public class EnglishLanguage
    {
        public static string lowBreachMessage = "Breaching point is low";
        public static string highBreachMessage = "Breaching point is high";
        public static string lowWarningMessage = "Warning: Approaching discharge";
        public static string highWarningMessage = "Warning: Approaching charge-peak";
    }
}
