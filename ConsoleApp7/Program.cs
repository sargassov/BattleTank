using System;
using System.Collections.Generic;
using System.Text;
using MyClassLib;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tТанковый бой\n\n\n");
            string T_34TankName = "T-34";
            string pantzerTankName = "Pantzer";

            List<Tank> T_34List = new List<Tank>();

            for(short x = 0; x<5; x++)
            {
                T_34List.Add(new T_34(T_34TankName));
            }

            List<Tank> PantzerList = new List<Tank>();

            for (short x = 0; x < 5; x++)
            {
                PantzerList.Add(new Pantzer(pantzerTankName));
            }


            for(short x = 0; x < 5; x++)
            {
                Console.WriteLine($"{x + 1} бой.\nТанк {T_34List[x].GetDescription()}.\n " +
                    $"Боекомплект = {T_34List[x].GetAmmunition()},\n Уровень брони = " +
                    $"{T_34List[x].GetArmor()},\n Маневренность = { T_34List[x].GetManeuverability()}\n" +
                    $" -- VS -- \nТанк {PantzerList[x].GetDescription()}.\n " +
                    $"Боекомплект = {PantzerList[x].GetAmmunition()},\n Уровень брони = " +
                    $"{PantzerList[x].GetArmor()},\n Маневренность = { PantzerList[x].GetManeuverability()}\n");

                Tank winnerTank = T_34List[x] * PantzerList[x];
                Console.WriteLine($"Побеждает танк {winnerTank.GetDescription()}\n\n");
            }
        }
    }
}
