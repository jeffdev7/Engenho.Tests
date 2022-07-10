using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGENHO.Lantern
{
    public class Lantern
    {
        public enum ELanternStatus
        {
            ON = 1,
            OFF
        }
        private static ELanternStatus MainState = ELanternStatus.OFF;
        public static ELanternStatus GetState()
        {
            return MainState;
        }

        public static bool SetLanternStatus()
        {
            switch (MainState)
            {
                case ELanternStatus.ON:
                    break;
                case ELanternStatus.OFF:
                    break;
                default:
                    break;
            }
            return true;
        }
        public static bool TurnLanternOn()
        {
            MainState = ELanternStatus.ON;
            Console.Write($"\n\nTurning the light on...");
            Console.WriteLine("\n\tTHE LIGHT IS ON", Console.ForegroundColor = ConsoleColor.Yellow);
            return true;
        }
        public static bool TurnLanternOff()
        {
            MainState = ELanternStatus.OFF;
            Console.WriteLine("\nYou're turning the light off...", Console.ForegroundColor = ConsoleColor.DarkYellow);
            return true;
        }
    }
}
