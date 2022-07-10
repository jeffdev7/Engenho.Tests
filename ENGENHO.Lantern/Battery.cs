using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGENHO.Lantern
{
    public class Battery
    {
        public enum EBatteryStatus
        {
            CURRENT = 1,
            DEAD,
            REPLACE
        }

        private static EBatteryStatus BatteryMainState = EBatteryStatus.CURRENT;
        //public static bool IsBatteryDead = false;
        public static EBatteryStatus GetState()
        {
            return BatteryMainState;
        }

        public static bool SetBatteryStatus()
        {
            switch (BatteryMainState)
            {
                case EBatteryStatus.CURRENT:
                    break;
                case EBatteryStatus.DEAD:
                    break;
                case EBatteryStatus.REPLACE:
                    break;
                default:
                    break;
            }
            return true;
        }
        public static bool ReplaceBattery()
        {
            BatteryMainState = EBatteryStatus.REPLACE;
            Console.Write($"\nReplacing the battery", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine("\n\tTHE BATTERY IS RECHARGED.\nPress 1 to light it up again", Console.ForegroundColor = ConsoleColor.Green);
            return true;
        }
    }
}
