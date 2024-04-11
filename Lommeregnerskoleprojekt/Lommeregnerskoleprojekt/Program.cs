namespace Lommeregner
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Start = true;
            int resultat = 0;

            do
            {


                Console.WriteLine("Tryk 1 - Plus");
                Console.WriteLine("Tryk 2 - Minus");
                Console.WriteLine("Tryk 3 - Dividere");
                Console.WriteLine("Tryk 4 - Gange");
                Console.WriteLine("Try 5 - EXIT");

                var choice = ReadInput(": ");

                if (choice == 1)
                {
                    Console.WriteLine("Indtast første tal");
                    var førsteTal = ReadInput(": ");

                    Console.WriteLine("Indtast anden tal 2");
                    var andenTal = ReadInput(": ");

                    resultat = førsteTal + andenTal;

                    Console.WriteLine(resultat);
                }
                if (choice == 2)
                {
                    Console.WriteLine("Indtast første tal");
                    var førsteTal = ReadInput(": ");

                    Console.WriteLine("Indtast anden tal 2");
                    var andenTal = ReadInput(": ");

                    resultat = førsteTal + andenTal;

                    Console.WriteLine(resultat);
                }
                if (choice == 3)
                {

                    Console.WriteLine("Indtast første tal");
                    var førsteTal = ReadInput(": ");

                    Console.WriteLine("Indtast anden tal");
                    var andenTal = ReadInput(": ");

                    resultat = førsteTal / andenTal;

                    Console.WriteLine(resultat);

                }
                if (choice == 4)
                {
                    Console.WriteLine("Indtast første tal");
                    var førsteTal = ReadInput(": ");

                    Console.WriteLine("Indtast andet tal");
                    var andenTal = ReadInput("Indtas: ");

                    resultat = førsteTal * andenTal;

                    Console.WriteLine(resultat);
                }
                if (choice == 5)
                {
                    Start = false;
                }
            } while (Start);
        }
        static int ReadInput(string promt)
        {
            Console.Write(promt);
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            return value;
        }
    }
}