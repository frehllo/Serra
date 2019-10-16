using System;

namespace Serra
{
    class Program
    {
        static void Main(string[] args)
        {
            string bene = "La temperatura va bene";
            string male = "La temperatura non va bene";
            string moltomale = "La serra è in pericolo";
            Console.Write("Quanti gradi ci sono nella serra?");
            double gradi = double.Parse(Console.ReadLine());
            if(gradi >= 18)
            {
                Console.WriteLine($"{bene}");
            }
            if( gradi < 18 && gradi > 5)
            {
                Console.WriteLine($"{male}");
            }
            if(gradi <= 5)
            {
                Console.WriteLine($"{moltomale}");                
            }
            Console.ReadLine();
        }
    }
}
