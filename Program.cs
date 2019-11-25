using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_game
{
    class Program
    {
        static void Main(String[] args)
        {
            int sayac = 1;
            int guess;

            Random rastgele = new Random();
            int retainedNumber = rastgele.Next(0, 100);

            do
            {
                Console.WriteLine("Please enter you guess");
                guess = int.Parse(Console.ReadLine());

                if (guess > retainedNumber  && sayac <= 10)
                    Console.WriteLine("Down");
                else if (guess < retainedNumber && sayac <= 10)
                    Console.WriteLine("Up");
                else if (guess == retainedNumber)
                {
                    Console.WriteLine("Congratulations!" + sayac + ". you know in the experiment ");
                }
                sayac++;
                if (sayac > 10)
                    Console.WriteLine("Your guess is over..");
            }
            while (guess != retainedNumber && sayac <= 10);
            Console.ReadKey();
        }
    }
}
     
