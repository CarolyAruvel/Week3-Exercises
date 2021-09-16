using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mitu kraadi on õues;
            //kui õues on rohkem kui 35 kraadi, programm kuvab "boiling hot"
            //kui õues on 30 kuni 35 kraadi, programm kuvab "hot"
            //kui õues 20 kuni 30 kraadi, programm kuvab "nice"
            //kui õues on 10 kuni 20 kraadi, programm kuvab "chilly"
            //kui õues on 0 kuni 10 kraadi, programm kuvab "cold"

            Console.WriteLine("Mitu kraadi õues on?");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 35)
            {
                Console.WriteLine("Boiling hot");
            }
            else if (temp >=30 && temp <35)
            {
                Console.WriteLine("hot");
            }
            else if (temp >=30 && temp <20)
            {
                Console.WriteLine("nice");
            }
            else if (temp >=20 && temp <10)
            {
                Console.WriteLine("chilly");
            }
            else if (temp >=0 && temp <10)
            {
                Console.WriteLine("cold");
            }
            else
            {
                Console.WriteLine("Freezing cold");
            }
        }
    }
}
