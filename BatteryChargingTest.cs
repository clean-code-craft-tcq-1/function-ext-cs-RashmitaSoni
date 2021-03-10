using System;
using System.Diagnostics;

namespace BatteryCharging
{   static class German
     {
            public static string faultyBatteryStatus = "Batterie ist defekt";
            public static string normalBatteryStatus = "Batterie ist in Ordnung";
            public static string lowBreachStatus = "Bruchstelle ist niedrig";
            public static string highBreachStatus = "Bruchstelle ist hoch";
            public static string lowWarningStatus = "Warnung: Annäherung an die Entladung";
            public static string highWarningStatus = "Warnung: Annäherung an die Ladungsspitze";
            public static string chargingTemperature = "Ladetemperatur";
            public static string stateOfCharge = "Ladezustand";
            public static string chargeRate = "Ladestrom";
      }
    static class English
    {
            public static string faultyBatteryStatus = "Battery is faulty";
            public static string normalBatteryStatus = "Battery is OK";
            public static string lowBreachStatus = "Breaching Point is Low";
            public static string highBreachStatus = "Breaching Point is High";
            public static string lowWarningStatus = "Warning: Approaching discharge";
            public static string highWarningStatus = "Warning: Approaching charge-peak";
            public static string chargingTemperature = "Charging Temperature";
            public static string stateOfCharge = "State of Charge";
            public static string chargeRate = "Charge Rate";
   }
public class BatteryChargingTest
    {
        public static void BatteryChargingTestFactors(float chargingTemperature_Celsius, float stateOfCharge_percentage, float chargeRate_CRate)
        {
            BatteryChargingTemperature.CheckChargingTemperature(chargingTemperature_Celsius);
            BatteryStateOfCharge.CheckStateOfCharge(stateOfCharge_percentage);
            BatteryChargeRate.CheckChargeRate(chargeRate_CRate);
            DisplayBatteryStatus();
        }
        public static void DisplayBatteryStatus()
        {
            if(BatteryAbnormalConditions.IsBatteryFaultyStatus())
            {
                DisplayBatteryStatus(English.faultyBatteryStatus, German.faultyBatteryStatus);
            }
            else
            {
                DisplayBatteryStatus(English.normalBatteryStatus, German.normalBatteryStatus);
            }
        }
        public static void DisplayBatteryStatus(string statusInEnglish, string statusInGerman)
        {
            Console.WriteLine("{0}\n{1}",statusInEnglish,statusInGerman);
        }
    }
}
