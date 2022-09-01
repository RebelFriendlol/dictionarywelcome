using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Giraffe
{


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> witam = new Dictionary<string, string>();

            witam.Add("english", "Welcome");
            witam.Add("czech", "Vitejte");
            witam.Add("danish", "Velkomst");
            witam.Add("dutch", "Welkom");
            witam.Add("estonian", "Tere tulemast");
            witam.Add("finnish", "Tervetuloa");
            witam.Add("flemish", "Welgekomen");
            witam.Add("german", "Willkommen");
            witam.Add("irish", "Failte");
            witam.Add("italian", "Benvenuto");
            witam.Add("lithuanian", "Laukiamas");
            witam.Add("polish", "Witamy");
            witam.Add("spanish", "Bienvenido");
            witam.Add("swedish", "Valkommen");
            witam.Add("welsh", "Croeso");

            Console.Write("Napsisz Witam w jakimś języku(użyj dużej litery na poczatku wyrazu) ");
            string language = Console.ReadLine();

            

            if (witam.ContainsValue(language))
            {
                switch (language)
                {
                    case "Welcome":
                        Console.WriteLine(witam.Keys.ElementAt(0));
                        break;
                    case "Vitejte":
                        Console.WriteLine(witam.Keys.ElementAt(1));
                        break;
                    case "Velkomst":
                        Console.WriteLine(witam.Keys.ElementAt(2));
                        break;
                    case "Welkom":
                        Console.WriteLine(witam.Keys.ElementAt(3));
                        break;
                    case "Tere tulemast":
                        Console.WriteLine(witam.Keys.ElementAt(4));
                        break;
                    case "Tervetuloa":
                        Console.WriteLine(witam.Keys.ElementAt(5));
                        break;
                    case "Welgekomen":
                        Console.WriteLine(witam.Keys.ElementAt(6));
                        break;
                    case "Willkommen":
                        Console.WriteLine(witam.Keys.ElementAt(7));
                        break;
                    case "Failte":
                        Console.WriteLine(witam.Keys.ElementAt(8));
                        break;
                    case "Benvenuto":
                        Console.WriteLine(witam.Keys.ElementAt(9));
                        break;
                    case "Laukiamas":
                        Console.WriteLine(witam.Keys.ElementAt(10));
                        break;
                    case "Witamy":
                        Console.WriteLine(witam.Keys.ElementAt(11));
                        break;
                    case "Bienvenido":
                        Console.WriteLine(witam.Keys.ElementAt(12));
                        break;
                    case "Valkommen":
                        Console.WriteLine(witam.Keys.ElementAt(13));
                        break;
                    case "Croeso":
                        Console.WriteLine(witam.Keys.ElementAt(14));
                        break;

                }
                
            }
            else
            {
                Console.WriteLine("Brak tego języka w bazie danych.");
            }





            Console.ReadLine();
        }




    }
}
