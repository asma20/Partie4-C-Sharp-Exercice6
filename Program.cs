using System;

namespace Partie4Exercice6nv
{
    class Program
    {

        enum week
        {
            lundi,    // 0
            Mardi,   // 1
            Mercredi,      // 2
            jeudi,      // 3
            vendredi,        // 4
            Samedi,       // 5
            Dimanche      // 6
        }


        static void Main(string[] args)
        {



            /*  foreach (int i in Enum.GetValues(typeof(week)))
              {
                  Console.WriteLine($" {i}");
              }
            */

            Console.WriteLine("***les élements du weeks***");
            foreach (string str in Enum.GetNames(typeof(week)))
            {
                Console.WriteLine(str);
            }

            int value = 3;

           String var = ((week)value).ToString();
            Console.WriteLine("la valeur 4 de l'énumération est "+var);


        }
    }
}
