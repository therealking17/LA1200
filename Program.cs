using System;

namespace Zufallszahl_generieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int genRand = r.Next(1, 100);
            Console.WriteLine("Erraten sie eine Zahl zwischen 1 und 100");
            // string ui = Console.ReadLine();
            // int guess = Convert.ToInt16(ui);
            bool correct = true;
            int V = 1;
            while (correct)
            {
                try
                {
                    string guessString = Console.ReadLine();
                    int guess = Convert.ToInt32(guessString);
                    if (guess < genRand)
                    {
                        Console.WriteLine("Zu klein");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Geben sie eine Zahl von 1-100");
                        V++;
                    }
                    else if (guess > genRand)
                    {
                        Console.WriteLine("Zu gross");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Geben sie eine Zahl von 1-100");
                        V++;
                    }

                    else if (guess == genRand)
                    {

                        //correct = true;
                        Console.WriteLine("Sie haben die richtige Zahl erraten!");
                        Console.WriteLine("Sie haben " + V + " Versuche gebraucht");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Geben sie bitte eine Zahl zwischen 1 und 100 ein: ");
                }
              
          
            }

        }



    }
}
