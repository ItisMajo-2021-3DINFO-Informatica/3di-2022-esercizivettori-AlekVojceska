using System;

namespace VojceskaVettoriNumero
{
    class Program
    {
        static void Main(string[] args)
        {
           
            const int dimensione = 400;
            int i = 0;
            Random generatore = new Random();
            for (int c = 0; c < dimensione; c++)
            {
                int numerocasuale = generatore.Next(0, 100);
                Console.WriteLine($"{numerocasuale}");
            }
            
        }
    }
}
