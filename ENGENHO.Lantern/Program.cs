using System;
using System.Collections.Generic;
using System.Threading;

namespace ENGENHO.Lantern
{
    internal class Program
    {
        /// <summary>
        /// 2 - Crie uma aplicação Windows que simule o funcionamento de uma lanterna, seguindo as regras abaixo:
        ///- Ao abrir o aplicativo, a lanterna deve estar com o status Desligada e a bateria deve estar 100%.
        ///- O aplicativo deve exibir o estado do botão liga/desliga, o estado da lanterna(ligada ou desligada) e a carga da bateria.
        ///- A lanterna possui um botão Liga/Desliga e um botão Trocar Bateria.
        ///- Ao ligar a lanterna, a bateria deve diminuir 1% de duração a cada 1 segundo.
        ///- Quando a bateria chegar a 0%, a lanterna desliga.
        ///- Ao Trocar Bateria, uma nova bateria com 100% de carga deve ser colocada no lugar da atual.
        ///- O aplicativo deverá obrigatoriamente ter uma classe Lanterna e uma classe Bateria.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\t========= LANTERN ==============\nButtons: ");

            List<string> buttons = new List<string>();
            buttons.Add("\t1 - ON (Press twice only for the first time)");
            buttons.Add("\t2 - OFF");
            buttons.Add("\t3 - RECHARGE");

            foreach (var btn in buttons)
            {
                Console.WriteLine(btn);
            }

            Thread turnLightOn = new Thread(RunLantern);
            turnLightOn.Start();

            Console.ReadKey();
        }
        static void BatteryState()
        {
            int batteryPercentage = 100;
            Thread LightOn = new Thread(RunLantern);

            for (int i = batteryPercentage; i >= 0; --i)
            {
                Console.WriteLine($"lantern's battery: {i}%");
                Thread.Sleep(1000);

                if (i == 0)
                {
                    Console.WriteLine("\n\tTHE LIGHT IS OFF", Console.ForegroundColor = ConsoleColor.Red);

                    try
                    {
                        Console.WriteLine("\nreplace the battery", Console.ForegroundColor = ConsoleColor.Red);

                        Thread.Sleep(100);

                    }
                    catch (ThreadAbortException)
                    {
                        Thread.ResetAbort();

                    }
                }
            }
        }
        static void RunLantern()
        {

            while (true)
            {
                var keyInfo = Console.ReadKey();
                Thread battery = new Thread(BatteryState);

                if (keyInfo.KeyChar == '1')
                {
                    Lantern.TurnLanternOn();
                    battery.Start();

                }

                if (keyInfo.KeyChar == '2')
                {
                    Lantern.TurnLanternOff();
                    Thread.Sleep(1000);
                    try
                    {
                        Console.WriteLine("The light off", Console.ForegroundColor = ConsoleColor.DarkYellow);
                        Environment.Exit(0);

                    }
                    catch (ThreadAbortException)
                    {
                        Thread.ResetAbort();

                    }
                }

                if (keyInfo.KeyChar == '3')
                    Battery.ReplaceBattery();
            }

        }
    }
    
}
