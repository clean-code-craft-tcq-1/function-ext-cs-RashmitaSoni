using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingTest
    {
        static IReporter _batteryReporter;
        public BatteryChargingTest(IReporter batteryReporter)
        {
            if (batteryReporter == null)
            {
                throw new InvalidProgramException("Invalid Program Exception Occurred !!!");
            }
            _batteryReporter = batteryReporter;
        }
        public static bool BatteryChargingTestFactors(float chargingTemperature_Celsius, float stateOfCharge_percentage, float chargeRate_CRate)
        {
            try
            {
                bool IsBatteryFaulty =
                    BatteryAbnormalConditions.CheckAbnormalConditions(BatteryChargingFactors.ChargingTemperature, chargingTemperature_Celsius, BatteryChargingFactors.minimumChargingTemprature_Celsius, BatteryChargingFactors.minimumChargingTemperatureWarning, BatteryChargingFactors.maximumChargingTemperatureWarning, BatteryChargingFactors.maximumChargingTemprature_Celsius)
                    | BatteryAbnormalConditions.CheckAbnormalConditions(BatteryChargingFactors.StateOfCharge, stateOfCharge_percentage, BatteryChargingFactors.minimumStateOfCharge_Percentage, BatteryChargingFactors.minimumStateOfChargeWarning, BatteryChargingFactors.maximumStateOfChargeWarning, BatteryChargingFactors.maximumStateOfCharge_Percentage)
                    | BatteryAbnormalConditions.CheckAbnormalConditions(BatteryChargingFactors.ChargeRate, chargeRate_CRate, BatteryChargingFactors.minimumChargeRate_CRate, BatteryChargingFactors.minimumChargeRateWarning, BatteryChargingFactors.maximumChargeRate_CRate, BatteryChargingFactors.maximumChargeRate_CRate);

                if (IsBatteryFaulty)
                {
                    BatteryAbnormalConditions.factorsConditions.Add(new Tuple<string, string>("Battery is faulty", "Batterie ist defekt"));
                }
                else
                {
                    BatteryAbnormalConditions.factorsConditions.Add(new Tuple<string, string>("Battery is OK", "Batterie ist in Ordnung"));
                }

                _batteryReporter.DisplayBatteryStatus(BatteryAbnormalConditions.factorsConditions);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
   }
}
