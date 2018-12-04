using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Sarah"
            };

            PlayerCharacter amrit = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Amrit"
            };

            PlayerCharacter gentry = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Gentry"
            };
            
            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);


            //PlayerCharacter player = new PlayerCharacter();
            //player.Name = ""; removed for Null-Conditional Operator ?. ?[
            //player.DaysSinceLastLogin = 42;

            //PlayerDisplayer.Write(player); //removed for Null-Conditional Operator ?. ?[ demo

            //int days = player?.DaysSinceLastLogin ?? -1;

            //PlayerCharacter[] players = null;

            //int days = player.DaysSinceLastLogin.Value;


            //Console.WriteLine(days);

            //string p1 = players?[0]?.Name;
            //string p2 = players?[1]?.Name;
            //string p3 = players?[2]?.Name;

            Console.ReadLine();
        }
    }
}
