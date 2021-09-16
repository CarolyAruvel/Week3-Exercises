using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Mitu punkti sa said matemaatikas?");
            int Mate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mitu punkti sa said keemias?");
            int Keemia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mitu punkti sa said bioloogias?");
            int bioloogia = Convert.ToInt32(Console.ReadLine());

            if (Mate >= 95 && Keemia >=90 && bioloogia >=95)
            {
                Console.WriteLine("Saad õppida arstiks");
            }
            else
            {
                Console.WriteLine("Ei saa õppida arstiks.");
            }
        }   

    }
}
