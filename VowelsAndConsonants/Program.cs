using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tähte
            //programm kontrollib, kas sisestatud täht on
            //täishäälik või kaashäälik
            //kui sisestatud täht on täishäälik - programm kuvab
            //"täishäälik"
            //kui sisestatud täht on kaashäälik
            //programm kuvab "kaashäälik"
            //kasutame switchi

            //"mingi sõna" - string
            //'a'   - character ehk char  

            Console.WriteLine("Sisesta täht:");
            char userCharacter = Convert.ToChar(Console.ReadLine().ToLower());

            switch (userCharacter)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    break;
                default:
                    Console.WriteLine("Consonants");
                    break;                                                     
            }
              
        }
    }
}
