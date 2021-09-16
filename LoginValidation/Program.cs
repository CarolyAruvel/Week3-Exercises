using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmed
            //kui sisestatud kasutajatunnus on "admin" ja
            //sisestatud parool on "admin1234"
            //siis programm kuvab "Tere tulemast!"
            //muul juhul programm kuvab "Vale kasutaja tunnus või parool. Proovi uuesti";

            Console.WriteLine("Sisestada kasutajatunnus");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sisesta parool");
            string Password = Console.ReadLine();

            /* if (UserName == "admin" && Password == "admin1234")
             {
                 Console.WriteLine("Tere tulemast!");
             }

             else 
             {
                 Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");
             }*/

            if (UserName != "admin" || Password != "admin1234")
            {
                Console.WriteLine("Vale kasutajayunnus või parool. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
