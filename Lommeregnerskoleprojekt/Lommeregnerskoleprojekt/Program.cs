namespace Lommeregner
{
    public class Program
    {
        static void Main(string[] args)
        {
            int resultat = 0;

            Console.WriteLine("Tryk 1 - Plus");
            Console.WriteLine("Tryk 2 - Minus");
            Console.WriteLine("Tryk 3 - Dividere");
            Console.WriteLine("Tryk 4 - Gange");

            var choice = ReadInput("Indtastete Tal: ");

            if (choice == 1)
            {
                Console.WriteLine("Indtast første tal");
                var førsteTal = ReadInput("Indtastete Tal: ");

                Console.WriteLine("Indtast anden tal 2");
                var andenTal = ReadInput("Indtastete Tal: ");

                resultat = førsteTal + andenTal;

                Console.WriteLine(resultat);
            }
            if (choice == 3)
            {

                Console.WriteLine("Indtast første tal");
                var førsteTal = ReadInput("Indtastete Tal: ");

                Console.WriteLine("Indtast anden tal 2");
                var andenTal = ReadInput("Indtastete Tal: ");

                resultat = førsteTal / andenTal;

                Console.WriteLine(resultat);

            }

            // Minus Logikken 
            if( choice == 2)
            {
                Console.WriteLine("Indtast første tal");
                var førsteTal = ReadInput("Indtastete Tal: ");

                Console.WriteLine("Indtast anden tal 2");
                var andenTal = ReadInput("Indtastete Tal: ");

                resultat = førsteTal + andenTal;

                Console.WriteLine(resultat);
            }

            // Dividere Logikken

            // Gange Logikken
        }

        // Kommentar et eller andet!
        static int ReadInput(string promt)
        {
            Console.Write(promt);
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            return value;
        }
    }
}