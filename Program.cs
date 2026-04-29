using System;
using System.Runtime.CompilerServices;

namespace ziua_saptamanii
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Apasa pe 1 daca doresti sa alegi masina BMW F90 ");
             Console.WriteLine("Apasa pe 2 daca doresti sa alegi masina BMW M6 ");
              Console.WriteLine("Apasa pe 3 daca doresti sa alegi masina Mercedes AMG GT 4-door ");
               Console.WriteLine("Apasa pe 4 daca doresti sa alegi masina Mercedes AMG a45s ");
                Console.WriteLine("Apasa pe 5 daca doresti sa alegi masina Nissan GT-R R35 ");
                 Console.WriteLine("Apasa pe 6 daca doresti sa alegi masina Volkswagen GTI 6 ");
                  Console.WriteLine("Apasa pe 7 daca doresti sa alegi masina Lexus 250 ");
            int alegere = Convert.ToInt32 (Console.ReadLine ());

            switch (alegere)
            {
                case 1:
                Console.WriteLine("Cheia de la BMW te asteapta ");
                break;
                case 2:
                Console.WriteLine("Cheia de la BMW te asteapta ");
                break;
                case 3:
                Console.WriteLine("Cheia de la Mercedes te asteapta");
                break;
                case 4:
                Console.WriteLine("Cheia de la Mercedes te asteapta");
                break;
                case 5:
                Console.WriteLine("Cheia de la Nissan te asteapta");
                break;
                case 6:
                Console.WriteLine("Cheia de la Volkswagen te asteapta");
                break;
                case 7:
                Console.WriteLine("Cheia de la Lexus te asteapta");
                break;
                default:
                Console.WriteLine("Nu ai ales nici o masina");
                break;
                
            }
        }
    }
}