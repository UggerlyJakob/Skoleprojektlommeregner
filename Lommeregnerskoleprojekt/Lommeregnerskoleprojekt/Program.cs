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

                Console.WriteLine("Indtast anden tal");
                var andenTal = ReadInput("Indtastete Tal: ");

                resultat = førsteTal + andenTal;

                Console.WriteLine(resultat);
            }
        }

        //asdjaksjd

        // Hej jeg hedder Emil

        static int ReadInput(string promt)
        {
            Console.Write(promt);
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            return value;
        }
    }
}