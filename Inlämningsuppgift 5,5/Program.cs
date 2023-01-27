using System;
namespace Uppgift_5_5
{
    class program
    {
        static void Main(string[] args)
        {
            int o = 0;
            Random random = new Random();
            Console.WriteLine("Skriv in antal frågor du vill ställa till programet");
            string f = Console.ReadLine();
            int b = int.Parse(f);
            Console.WriteLine(" ");
            Console.WriteLine("Ställ en ja/nej fråga");
            for (int i = 0; i < b; i++)
                
            {
               
                if (o == 1)
                {
                    Console.WriteLine("Ställ en till fråga");
                }
               

                String[] Svar = new string[10];
                Svar[0] = ("Ja ");
                Svar[1] = ("Nej ");
                Svar[2] = ("Kanske ");
                Svar[3] = ("Troligtviss inte ");
                Svar[4] = ("Möjligen ");
                Svar[5] = ("Absolut ");
                Svar[6] = ("Antagligen ");
                Svar[7] = ("Definitivt ");
                Svar[8] = ("Aldrig ");
                Svar[9] = ("Säkert");

                string c = Console.ReadLine();
               
                for (int j = 0; j < c.Length; j++)
                {
                    char tecken1 = ('a');
                    char tecken = c[j];
                    if (tecken == tecken1)
                    {
                        c = "a";
                        break;
                    }
                }
                if (c == "a")
                {
                    break;
                }

                Console.WriteLine(" ");
                Console.WriteLine(Svar[random.Next(0, 9)]);
                Console.WriteLine(" ");
                o = 1;
            }
        }
    }
}